﻿/*flexberryautogenerated="true"*/
namespace IIS.Abiturient
{
    using System;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class АбитуриентL : BaseListForm<Абитуриент>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public АбитуриентL() : base(Абитуриент.Views.АбитуриентL)
        {
            EditPage = АбитуриентE.FormPath;
            

        }

        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Abiturient/AbiturientL.aspx"; }
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
