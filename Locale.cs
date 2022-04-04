using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERSaveManager.Locale
{
    public interface ITranslate
    {
        string STR_TITLE { get; }
        string STR_QUICKSAVE { get; }
        string STR_QUICKLOAD { get; }
        string STR_INITSAVE { get; }
        string STR_RECORD_RENAME { get; }
        string STR_RECORD_RESTORE { get; }
        string STR_RECORD_DELETE { get; }
        string MSG_DELETE_CONFIRM { get; }
    }

    public class English : ITranslate
    {
        string ITranslate.STR_TITLE { get; } = "ELDEN RING Savedata Manager";
        string ITranslate.STR_QUICKSAVE { get; } = "Quick Save (&F5)";
        string ITranslate.STR_QUICKLOAD { get; } = "Quick Load (&F9)";
        string ITranslate.STR_INITSAVE { get; } = "Init SaveData";
        string ITranslate.STR_RECORD_RENAME { get; } = "RENAME";
        string ITranslate.STR_RECORD_RESTORE { get; } = "RESTORE";
        string ITranslate.STR_RECORD_DELETE { get; } = "DELETE";
        string ITranslate.MSG_DELETE_CONFIRM { get; } = "Delete this savedata record?\nIt can not be undo!";
    }

    public class Chinese : ITranslate
    {
        string ITranslate.STR_TITLE { get; } = "ELDEN RING 存檔管理工具";
        string ITranslate.STR_QUICKSAVE { get; } = "快速備份 (&F5)";
        string ITranslate.STR_QUICKLOAD { get; } = "快速還原 (&F9)";
        string ITranslate.STR_INITSAVE { get; } = "設定初始存檔";
        string ITranslate.STR_RECORD_RENAME { get; } = "重新命名";
        string ITranslate.STR_RECORD_RESTORE { get; } = "還原存檔";
        string ITranslate.STR_RECORD_DELETE { get; } = "刪除存檔";
        string ITranslate.MSG_DELETE_CONFIRM { get; } = "要刪除該存檔紀錄嗎? 刪除後將永久消失!";
    }
}
