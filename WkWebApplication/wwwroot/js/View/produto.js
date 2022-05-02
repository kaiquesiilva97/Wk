$(document).ready(function () {
    obterProdutos("");
});
function obterProdutos(pesq) {
    let status = $("#radioTodos").prop("checked") ? 'Todos' : $("#radioAtivo").prop("checked") ? 'Ativo' : 'Inativo';

        $.ajax({
            type: 'GET',
            url: 'api/ProdutoApi',
            dataType: 'json',
            contentType: 'application/json',
            data: { resultado: pesq, filtro : status },
            success: function (result) {
                PreencherTabela(result);
            },
            error: function (XMLHttpRequest, txtStatus, errorThrown) {
                alert("Status: " + txtStatus); alert("Error: " + errorThrown);
            }
        });
    
}; 

function Alterar(id) {
    $("#txtCabecalhoCadastro").html("Alteração de Produto");
    $.ajax({
        type: 'GET',
        url: 'api/ProdutoApi/' + id,
        data: { Id: id },
        success: function (result) {
            if (Object.keys(result).length > 0) {
                $.fancybox.open({
                    src: '#formNovoProduto',
                    type: 'inline'
                });
                $("#txtDesc").val(result.descricao);
                $("#txtId").val(result.id);
                $("#txtCodBarra").val(result.codigoBarra);
                $("#txtObs").val(result.observacao);
                $("#cbbCat").val(result.categoria.id);
                $("#txtQuantAtual").val(result.qtdeAtual);
                $("#txtQuantMin").val(result.qtdeMinima);
                $("#txtVlrCusto").val(result.valorCusto);
                $("#txtVlrVenda").val(result.valorVenda);
                $("#cbbStatus").val(result.status);
            }
        },
        error: function (XMLHttpRequest, txtStatus, errorThrown) {
            alert("Status: " + txtStatus); alert("Error: " + errorThrown);
        }
    });
};
$('#btnPesquisar').click(function () {
    txtPalavraChave = $("#txtPalavraChave").val();

    obterProdutos(txtPalavraChave, status);
})
function Excluir(id) {
    bootbox.confirm({
        message: "Confirma a exclusão deste produto?",
        buttons: {
            confirm: {
                label: 'Sim',
                className: 'btn-success'
            },
            cancel: {
                label: 'Não',
                className: 'btn-danger'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    type: 'DELETE',
                    url: 'api/ProdutoApi/' + id,
                    success: function (result) {
                        if (result > 0) {
                            obterProdutos();
                        }
                        else {
                            bootbox.alert("Erro ao excluir")
                        }
                    },
                    error: function (XMLHttpRequest, txtStatus, errorThrown) {
                        alert("Status: " + txtStatus); alert("Error: " + errorThrown);
                    }
                });
            }
        }
    });
}
function PreencherTabela(dados) {
    var txt = '<thead>\
            <tr>\
                <th>ID</th>\
                <th>Descrição</th>\
                <th>Cod. Barra</th>\
                <th>Categoria</th>\
                <th>Status</th>\
                <th>Ações</th>\
            </tr>\
        </thead >\
        <tbody>';
    $.each(dados, function () {
        txt += `<tr><td> ${this.id} </td> <td> ${this.descricao} </td>  <td> ${this.codigoBarra} </td> <td> ${this.categoria.descricao} </td> <td> ${this.status == 'A' ? 'Ativo' : 'Inativo'} </td>  
            </td>
                <td class="espItemTagTd"> <a role="button" class="btn btn-warning espItemTagA" href="javascript:Alterar(${this.id})">Alterar</a>\
                <a role="button" class="btn btn-danger altBtnExlList" href="javascript:Excluir(${this.id})">Excluir</a>\
                </td></tr>`;
    });
    txt += '</tbody>';
    $("#tableProduto").html(txt);
};
function onBlurQtdeAtual() {
    onBlurDecimal('txtQuantAtual');
}
function onBlurQtdeMin() {
    onBlurDecimal('txtQuantMin');
}
function onBlurVlrCusto() {
    onBlurDecimal('txtVlrCusto');
}
function onBlurVlrVenda(){
    onBlurDecimal('txtVlrVenda');
}
function onBlurDecimal(name) {
    var txtAsc = document.getElementById(name).value.replace(',', '.');
    if (txtAsc == '')
        document.getElementById(name).value = 0;
}
function verifica(descricao, codBarra, obs, idCat, qtdeAtual, qtdeMin, vlrCusto, vlrVenda) {
    let msg = "";
    if (descricao == "" || descricao.length > 120)
        msg += ". Por favor, informe a descrição corretamente até 80 carcteres. <br />";
    if (codBarra.length > 30)
        msg +=  ". Por favor, codigo de barra até 30 carcteres. <br />";
    if (obs.length > 500)
        msg += ". Por favor, observação até 500 carcteres. <br />";
    if (isNaN(qtdeAtual)) {
        if (isNaN(qtdeAtual.replace(',', '.')))
            msg += ". Por favor, informe a quantidade atual corretamente em formato decimal. <br/>";
    }
    if (isNaN(qtdeMin)) {
        if (isNaN(qtdeMin.replace(',', '.')))
            msg += ". Por favor, informe a quantidade minima corretamente em formato decimal. <br/>";
    }
    if (isNaN(vlrCusto)) {
        if (isNaN(vlrCusto.replace(',', '.')))
            msg += ". Por favor, informe a valor de custo corretamente em formato decimal. <br/>";
    }
    if (isNaN(vlrVenda)) {
        if (isNaN(vlrCusto.replace(',', '.')))
            msg += ". Por favor, informe a valor de venda corretamente em formato decimal. <br/>";
    }
    return msg;
}
$('#btnNovoProduto').click(function () {
    $("#txtDesc").val("");
    $("#txtId").val(0);
    $("#txtCodBarra").val("");
    $("#txtObs").val("");
    $('#cbbCat option:eq(0)').prop('selected', true);
    $("#txtQuantAtual").val("0");
    $("#txtQuantMin").val("0");
    $("#txtVlrCusto").val("0");
    $("#txtVlrVenda").val("0");
    $("#cbbStatus").val("A");
})
$("#btnGravar").click(function () {

    let descricao = $("#txtDesc").val();
    let id = $("#txtId").val();
    let codBarra = $("#txtCodBarra").val();
    let obs = $("#txtObs").val();
    let idCat = $('#cbbCat').val();
    let qtdeAtual = $("#txtQuantAtual").val();
    let qtdeMin = $("#txtQuantMin").val();
    let vlrCusto = $("#txtVlrCusto").val();
    let vlrVenda = $("#txtVlrVenda").val();
    let status = $("#cbbStatus").val();
    let msg = verifica(descricao, codBarra, obs, idCat, qtdeAtual, qtdeMin, vlrCusto, vlrVenda);
    let Categoria = new Object();
    Categoria.Id = idCat;
    Categoria.Descricao = "";
    let Produto = new Object();
    Produto.Id = id;
    Produto.CodigoBarra = codBarra;
    Produto.Descricao = descricao;
    Produto.Observacao = obs;
    Produto.QtdeAtual = qtdeAtual;
    Produto.QtdeMinima = qtdeMin;
    Produto.ValorCusto = vlrCusto;
    Produto.ValorVenda = vlrVenda;
    Produto.Status = status;
    Produto.Categoria = Categoria;
    if (msg.length == 0) {
        if (id == 0) {
            $.ajax({
                type: 'POST',
                url: 'api/ProdutoApi',
                dataType: 'json',
                contentType: 'application/json',
                data: JSON.stringify(Produto),
                success: function (result) {
                    if (result > 0) {
                        obterProdutos("");
                        parent.$.fancybox.close();
                    }
                    else
                        Mensagem("divAlertaCadCat", "Erro ao gravar");
                },
                error: function (XMLHttpRequest, txtStatus, errorThrown) {
                    alert("Status: " + txtStatus); alert("Error: " + errorThrown);
                }
            });
        }
        else {
            $.ajax({
                type: 'PUT',
                url: 'api/ProdutoApi',
                dataType: 'json',
                contentType: 'application/json',
                data: JSON.stringify(Produto),
                success: function (result) {
                    if (result > 0) {
                        obterProdutos();
                        parent.$.fancybox.close();
                    }
                    else
                        Mensagem("divAlertaCadCat", "Erro ao Alterar");
                    closeInput();
                },
                error: function (XMLHttpRequest, txtStatus, errorThrown) {
                    alert("Status: " + txtStatus); alert("Error: " + errorThrown);
                }
            });
        }
    }
    else
        Mensagem("divAlertaCadCat", msg);
});