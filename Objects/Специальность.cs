﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Abiturient
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Специальность.
    /// </summary>
    // *** Start programmer edit section *** (Специальность CustomAttributes)

    // *** End programmer edit section *** (Специальность CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СпециальностьE", new string[] {
            "НомерСпециальности as \'Номер специальности\'",
            "Наименование as \'Наименование\'",
            "ТипЗаявления as \'ТипЗаявления\'",
            "ТипЗаявления.Наименование",
            "Факультет as \'Факультет\'",
            "Факультет.НазваниеФакультета"}, Hidden=new string[] {
            "НомерСпециальности"})]
    [MasterViewDefineAttribute("СпециальностьE", "ТипЗаявления", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [MasterViewDefineAttribute("СпециальностьE", "Факультет", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "НазваниеФакультета")]
    [View("СпециальностьL", new string[] {
            "НомерСпециальности as \'Номер специальности\'",
            "Наименование as \'Наименование\'",
            "ТипЗаявления",
            "ТипЗаявления.Наименование",
            "Факультет",
            "Факультет.НазваниеФакультета"}, Hidden=new string[] {
            "НомерСпециальности",
            "ТипЗаявления",
            "Факультет"})]
    [MasterViewDefineAttribute("СпециальностьL", "ТипЗаявления", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [MasterViewDefineAttribute("СпециальностьL", "Факультет", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "НазваниеФакультета")]
    public class Специальность : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомерСпециальности;
        
        private string fНаименование;
        
        private IIS.Abiturient.ТипЗаявления fТипЗаявления;
        
        private IIS.Abiturient.Факультет fФакультет;
        
        // *** Start programmer edit section *** (Специальность CustomMembers)

        // *** End programmer edit section *** (Специальность CustomMembers)

        
        /// <summary>
        /// НомерСпециальности.
        /// </summary>
        // *** Start programmer edit section *** (Специальность.НомерСпециальности CustomAttributes)

        // *** End programmer edit section *** (Специальность.НомерСпециальности CustomAttributes)
        public virtual int НомерСпециальности
        {
            get
            {
                // *** Start programmer edit section *** (Специальность.НомерСпециальности Get start)

                // *** End programmer edit section *** (Специальность.НомерСпециальности Get start)
                int result = this.fНомерСпециальности;
                // *** Start programmer edit section *** (Специальность.НомерСпециальности Get end)

                // *** End programmer edit section *** (Специальность.НомерСпециальности Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Специальность.НомерСпециальности Set start)

                // *** End programmer edit section *** (Специальность.НомерСпециальности Set start)
                this.fНомерСпециальности = value;
                // *** Start programmer edit section *** (Специальность.НомерСпециальности Set end)

                // *** End programmer edit section *** (Специальность.НомерСпециальности Set end)
            }
        }
        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (Специальность.Наименование CustomAttributes)

        // *** End programmer edit section *** (Специальность.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (Специальность.Наименование Get start)

                // *** End programmer edit section *** (Специальность.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (Специальность.Наименование Get end)

                // *** End programmer edit section *** (Специальность.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Специальность.Наименование Set start)

                // *** End programmer edit section *** (Специальность.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (Специальность.Наименование Set end)

                // *** End programmer edit section *** (Специальность.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Специальность.
        /// </summary>
        // *** Start programmer edit section *** (Специальность.ТипЗаявления CustomAttributes)

        // *** End programmer edit section *** (Специальность.ТипЗаявления CustomAttributes)
        [PropertyStorage(new string[] {
                "ТипЗаявления"})]
        [NotNull()]
        public virtual IIS.Abiturient.ТипЗаявления ТипЗаявления
        {
            get
            {
                // *** Start programmer edit section *** (Специальность.ТипЗаявления Get start)

                // *** End programmer edit section *** (Специальность.ТипЗаявления Get start)
                IIS.Abiturient.ТипЗаявления result = this.fТипЗаявления;
                // *** Start programmer edit section *** (Специальность.ТипЗаявления Get end)

                // *** End programmer edit section *** (Специальность.ТипЗаявления Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Специальность.ТипЗаявления Set start)

                // *** End programmer edit section *** (Специальность.ТипЗаявления Set start)
                this.fТипЗаявления = value;
                // *** Start programmer edit section *** (Специальность.ТипЗаявления Set end)

                // *** End programmer edit section *** (Специальность.ТипЗаявления Set end)
            }
        }
        
        /// <summary>
        /// Специальность.
        /// </summary>
        // *** Start programmer edit section *** (Специальность.Факультет CustomAttributes)

        // *** End programmer edit section *** (Специальность.Факультет CustomAttributes)
        [PropertyStorage(new string[] {
                "Факультет"})]
        [NotNull()]
        public virtual IIS.Abiturient.Факультет Факультет
        {
            get
            {
                // *** Start programmer edit section *** (Специальность.Факультет Get start)

                // *** End programmer edit section *** (Специальность.Факультет Get start)
                IIS.Abiturient.Факультет result = this.fФакультет;
                // *** Start programmer edit section *** (Специальность.Факультет Get end)

                // *** End programmer edit section *** (Специальность.Факультет Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Специальность.Факультет Set start)

                // *** End programmer edit section *** (Специальность.Факультет Set start)
                this.fФакультет = value;
                // *** Start programmer edit section *** (Специальность.Факультет Set end)

                // *** End programmer edit section *** (Специальность.Факультет Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СпециальностьE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СпециальностьE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СпециальностьE", typeof(IIS.Abiturient.Специальность));
                }
            }
            
            /// <summary>
            /// "СпециальностьL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СпециальностьL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СпециальностьL", typeof(IIS.Abiturient.Специальность));
                }
            }
        }
    }
}
