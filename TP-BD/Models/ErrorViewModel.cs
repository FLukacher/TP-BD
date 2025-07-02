using Microsoft.Data.SqlClient;
using Dapper;
namespace TP_BD.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
