﻿/*flexberryautogenerated="true"*/
namespace IIS.Abiturient
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ФакультетL : BaseListForm<Факультет>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ФакультетL() : base(Факультет.Views.ФакультетL)
        {
            EditPage = ФакультетE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Fakultet/FakultetL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
