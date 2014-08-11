#region Importações do sistema
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#endregion

namespace SysShop.Forms.UserControls
{
    /// <summary> Interface para User Controls que possuam um botão de confirmação </summary>
    public interface IAcceptableControl
    {
        /// <summary> Retorna o botão tido como botão de confirmação </summary>
        Button AcceptButton { get; }
    }
}
