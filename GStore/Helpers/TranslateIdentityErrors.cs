namespace GStore.Helpers;

public static class TranslateIndentityErrors
{
    public static string TranslateErrorMessage(string codeError)
    {
        string message = codeError switch
        {
            "DefaultError" => "Ocorreu um erro desconhecido.",
            "ConcurrencyFailure" => "Falha de concorrência otimista, o objeto foi modificado.",
            "InvalidToken" => "Token inválido",
            "LoginAlreadyAssociated" => "Já existe um usuário com este login.", 
            "InvalidUserName" => $"Este login é inválido, um login deve conter apenas letras ou dígitos.";
            "InvalidEmail" => "Email inválido.", 
        };
    }
    
}


