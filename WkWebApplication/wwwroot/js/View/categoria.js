$(document).ready(function () {
    obterCategoria("");
});
function obterCategoria(pesq) {
    if (pesq == "") {
        $.getJSON("/api/CategoriaApi/", function (data) {
            PreencherTabela(data);
        });
    }
    else {
        $.ajax({
            type: 'GET',
            url: 'api/CategoriaApi',
            dataType: 'json',
            contentType: 'application/json',
            data: { resultado : pesq},
            success: function (result) {
                PreencherTabela(result);
            },
            error: function (XMLHttpRequest, txtStatus, errorThrown) {
                alert("Status: " + txtStatus); alert("Error: " + errorThrown);
            }
        });
    }
}; 
$('#btnPesquisar').click(function () {
    txtPalavraChave = $("#txtPalavraChave").val();
    obterCategoria(txtPalavraChave);
})
$('#btnCancelar').click(function () {
    parent.$.fancybox.close();
})
$('#btnNovaCategoria').click(function () {
    $("#txtId").val(0);
    $("#txtDesc").val("");
    $("#txtCabecalhoCadastro").html("Cadastro de Categoria");
})

$("#btnGravar").click(function () {

    let descricao = $("#txtDesc").val();
    let id = $("#txtId").val();
    let msg = "";
    if (descricao == "" || descricao.length > 80)
        msg += ". Por favor, informe a descrição corretamente até 80 carcteres. <br />";
    var Categoria = new Object();
    Categoria.Descricao = descricao;
    Categoria.Id = id;
    if (msg.length == 0) {
        if (id == 0) {
            $.ajax({
                type: 'POST',
                url: 'api/CategoriaApi',
                dataType: 'json',
                contentType: 'application/json',
                data: JSON.stringify(Categoria),
                success: function (result) {
                    if (result > 0) {
                        obterCategoria();
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
                url: 'api/CategoriaApi',
                dataType: 'json',
                contentType: 'application/json',
                data: JSON.stringify(Categoria),
                success: function (result) {
                    if (result > 0) {
                        obterCategoria();
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
function Alterar(id) {
    $("#txtCabecalhoCadastro").html("Alteração de Categoria");
    $.ajax({
        type: 'GET',
        url: 'api/CategoriaApi/'+id,
        data: { Id: id },
        success: function (result) {
            if (Object.keys(result).length > 0) {
                $.fancybox.open({
                    src: '#formNovaCategoria',
                    type: 'inline'
                });
                $("#txtDesc").val(result.descricao);
                $("#txtId").val(result.id);
            }
        },
        error: function (XMLHttpRequest, txtStatus, errorThrown) {
            alert("Status: " + txtStatus); alert("Error: " + errorThrown);
        }
    });
};
function Mensagem(div, msg) {
    $("#" + div).html(msg);
    $("#" + div).show(300);
    $("#" + div).delay(5000);
    $("#" + div).hide(300);
};
function Excluir(id) {
    bootbox.confirm({
        message: "Confirma a exclusão dessa categoria?",
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
                    url: 'api/CategoriaApi/' + id,
                    success: function (result) {
                        if (result > 0) {
                            obterCategoria("");
                        }
                        else {
                            bootbox.alert("Erro ao excluir: Categoria pertence em um ou mais produtos.")
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
                <th>Ações</th>\
            </tr>\
        </thead >\
        <tbody>';
    $.each(dados, function () {
        txt += `<tr><td> ${this.id} </td> <td> ${this.descricao} </td> 
            </td>
                <td> <a role="button" class="btn btn-warning" href="javascript:Alterar(${this.id})">Alterar</a>\
                <a role="button" class="btn btn-danger" href="javascript:Excluir(${this.id})">Excluir</a>\
                </td></tr>`;
    });
    txt += '</tbody>';
    $("#tableCategoria").html(txt);
};