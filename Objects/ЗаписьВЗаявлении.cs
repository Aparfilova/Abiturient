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
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Запись в заявлении.
    /// </summary>
    // *** Start programmer edit section *** (ЗаписьВЗаявлении CustomAttributes)

    // *** End programmer edit section *** (ЗаписьВЗаявлении CustomAttributes)
    [BusinessServer("IIS.Abiturient.БизнесЛогика, Abiturient.BusinessServers", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [Caption("Запись в заявлении")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗаписьВЗаявленииE", new string[] {
            "СрокОбучения as \'Срок обучения\'",
            "Приоритет as \'Приоритет\'",
            "Специальность",
            "Специальность.Наименование as \'Наименование\'"})]
    public class ЗаписьВЗаявлении : ICSSoft.STORMNET.DataObject
    {
        
        private int fСрокОбучения;
        
        private int fПриоритет;
        
        private IIS.Abiturient.Специальность fСпециальность;
        
        private IIS.Abiturient.Заявление fЗаявление;
        
        // *** Start programmer edit section *** (ЗаписьВЗаявлении CustomMembers)

        // *** End programmer edit section *** (ЗаписьВЗаявлении CustomMembers)

        
        /// <summary>
        /// СрокОбучения.
        /// </summary>
        // *** Start programmer edit section *** (ЗаписьВЗаявлении.СрокОбучения CustomAttributes)

        // *** End programmer edit section *** (ЗаписьВЗаявлении.СрокОбучения CustomAttributes)
        public virtual int СрокОбучения
        {
            get
            {
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.СрокОбучения Get start)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.СрокОбучения Get start)
                int result = this.fСрокОбучения;
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.СрокОбучения Get end)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.СрокОбучения Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.СрокОбучения Set start)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.СрокОбучения Set start)
                this.fСрокОбучения = value;
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.СрокОбучения Set end)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.СрокОбучения Set end)
            }
        }
        
        /// <summary>
        /// Приоритет.
        /// </summary>
        // *** Start programmer edit section *** (ЗаписьВЗаявлении.Приоритет CustomAttributes)

        // *** End programmer edit section *** (ЗаписьВЗаявлении.Приоритет CustomAttributes)
        public virtual int Приоритет
        {
            get
            {
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.Приоритет Get start)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.Приоритет Get start)
                int result = this.fПриоритет;
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.Приоритет Get end)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.Приоритет Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.Приоритет Set start)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.Приоритет Set start)
                this.fПриоритет = value;
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.Приоритет Set end)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.Приоритет Set end)
            }
        }
        
        /// <summary>
        /// Запись в заявлении.
        /// </summary>
        // *** Start programmer edit section *** (ЗаписьВЗаявлении.Специальность CustomAttributes)

        // *** End programmer edit section *** (ЗаписьВЗаявлении.Специальность CustomAttributes)
        [PropertyStorage(new string[] {
                "Специальность"})]
        [NotNull()]
        public virtual IIS.Abiturient.Специальность Специальность
        {
            get
            {
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.Специальность Get start)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.Специальность Get start)
                IIS.Abiturient.Специальность result = this.fСпециальность;
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.Специальность Get end)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.Специальность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.Специальность Set start)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.Специальность Set start)
                this.fСпециальность = value;
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.Специальность Set end)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.Специальность Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Abiturient.Заявление.
        /// </summary>
        // *** Start programmer edit section *** (ЗаписьВЗаявлении.Заявление CustomAttributes)

        // *** End programmer edit section *** (ЗаписьВЗаявлении.Заявление CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Заявление"})]
        public virtual IIS.Abiturient.Заявление Заявление
        {
            get
            {
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.Заявление Get start)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.Заявление Get start)
                IIS.Abiturient.Заявление result = this.fЗаявление;
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.Заявление Get end)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.Заявление Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.Заявление Set start)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.Заявление Set start)
                this.fЗаявление = value;
                // *** Start programmer edit section *** (ЗаписьВЗаявлении.Заявление Set end)

                // *** End programmer edit section *** (ЗаписьВЗаявлении.Заявление Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗаписьВЗаявленииE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаписьВЗаявленииE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаписьВЗаявленииE", typeof(IIS.Abiturient.ЗаписьВЗаявлении));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ЗаписьВЗаявлении.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfЗаписьВЗаявлении CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfЗаписьВЗаявлении CustomAttributes)
    public class DetailArrayOfЗаписьВЗаявлении : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Abiturient.DetailArrayOfЗаписьВЗаявлении members)

        // *** End programmer edit section *** (IIS.Abiturient.DetailArrayOfЗаписьВЗаявлении members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ЗаписьВЗаявлении by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ЗаписьВЗаявлении.
        /// </summary>
        public DetailArrayOfЗаписьВЗаявлении(IIS.Abiturient.Заявление fЗаявление) : 
                base(typeof(ЗаписьВЗаявлении), ((ICSSoft.STORMNET.DataObject)(fЗаявление)))
        {
        }
        
        public IIS.Abiturient.ЗаписьВЗаявлении this[int index]
        {
            get
            {
                return ((IIS.Abiturient.ЗаписьВЗаявлении)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Abiturient.ЗаписьВЗаявлении dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
