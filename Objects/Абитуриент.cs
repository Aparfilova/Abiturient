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
    /// Абитуриент.
    /// </summary>
    // *** Start programmer edit section *** (Абитуриент CustomAttributes)

    // *** End programmer edit section *** (Абитуриент CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("АбитуриентE", new string[] {
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "Возраст as \'Возраст\'",
            "Город as \'Город\'",
            "Адрес as \'Адрес\'"})]
    [View("АбитуриентL", new string[] {
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "Возраст as \'Возраст\'",
            "Адрес as \'Адрес\'",
            "Город as \'Город\'"})]
    public class Абитуриент : ICSSoft.STORMNET.DataObject
    {
        
        private string fФамилия;
        
        private string fИмя;
        
        private string fОтчество;
        
        private int fВозраст;
        
        private string fГород;
        
        private string fАдрес;
        
        // *** Start programmer edit section *** (Абитуриент CustomMembers)

        // *** End programmer edit section *** (Абитуриент CustomMembers)

        
        /// <summary>
        /// Фамилия.
        /// </summary>
        // *** Start programmer edit section *** (Абитуриент.Фамилия CustomAttributes)

        // *** End programmer edit section *** (Абитуриент.Фамилия CustomAttributes)
        [StrLen(255)]
        public virtual string Фамилия
        {
            get
            {
                // *** Start programmer edit section *** (Абитуриент.Фамилия Get start)

                // *** End programmer edit section *** (Абитуриент.Фамилия Get start)
                string result = this.fФамилия;
                // *** Start programmer edit section *** (Абитуриент.Фамилия Get end)

                // *** End programmer edit section *** (Абитуриент.Фамилия Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Абитуриент.Фамилия Set start)

                // *** End programmer edit section *** (Абитуриент.Фамилия Set start)
                this.fФамилия = value;
                // *** Start programmer edit section *** (Абитуриент.Фамилия Set end)

                // *** End programmer edit section *** (Абитуриент.Фамилия Set end)
            }
        }
        
        /// <summary>
        /// Имя.
        /// </summary>
        // *** Start programmer edit section *** (Абитуриент.Имя CustomAttributes)

        // *** End programmer edit section *** (Абитуриент.Имя CustomAttributes)
        [StrLen(255)]
        public virtual string Имя
        {
            get
            {
                // *** Start programmer edit section *** (Абитуриент.Имя Get start)

                // *** End programmer edit section *** (Абитуриент.Имя Get start)
                string result = this.fИмя;
                // *** Start programmer edit section *** (Абитуриент.Имя Get end)

                // *** End programmer edit section *** (Абитуриент.Имя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Абитуриент.Имя Set start)

                // *** End programmer edit section *** (Абитуриент.Имя Set start)
                this.fИмя = value;
                // *** Start programmer edit section *** (Абитуриент.Имя Set end)

                // *** End programmer edit section *** (Абитуриент.Имя Set end)
            }
        }
        
        /// <summary>
        /// Отчество.
        /// </summary>
        // *** Start programmer edit section *** (Абитуриент.Отчество CustomAttributes)

        // *** End programmer edit section *** (Абитуриент.Отчество CustomAttributes)
        [StrLen(255)]
        public virtual string Отчество
        {
            get
            {
                // *** Start programmer edit section *** (Абитуриент.Отчество Get start)

                // *** End programmer edit section *** (Абитуриент.Отчество Get start)
                string result = this.fОтчество;
                // *** Start programmer edit section *** (Абитуриент.Отчество Get end)

                // *** End programmer edit section *** (Абитуриент.Отчество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Абитуриент.Отчество Set start)

                // *** End programmer edit section *** (Абитуриент.Отчество Set start)
                this.fОтчество = value;
                // *** Start programmer edit section *** (Абитуриент.Отчество Set end)

                // *** End programmer edit section *** (Абитуриент.Отчество Set end)
            }
        }
        
        /// <summary>
        /// Возраст.
        /// </summary>
        // *** Start programmer edit section *** (Абитуриент.Возраст CustomAttributes)

        // *** End programmer edit section *** (Абитуриент.Возраст CustomAttributes)
        public virtual int Возраст
        {
            get
            {
                // *** Start programmer edit section *** (Абитуриент.Возраст Get start)

                // *** End programmer edit section *** (Абитуриент.Возраст Get start)
                int result = this.fВозраст;
                // *** Start programmer edit section *** (Абитуриент.Возраст Get end)

                // *** End programmer edit section *** (Абитуриент.Возраст Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Абитуриент.Возраст Set start)

                // *** End programmer edit section *** (Абитуриент.Возраст Set start)
                this.fВозраст = value;
                // *** Start programmer edit section *** (Абитуриент.Возраст Set end)

                // *** End programmer edit section *** (Абитуриент.Возраст Set end)
            }
        }
        
        /// <summary>
        /// Город.
        /// </summary>
        // *** Start programmer edit section *** (Абитуриент.Город CustomAttributes)

        // *** End programmer edit section *** (Абитуриент.Город CustomAttributes)
        [StrLen(255)]
        public virtual string Город
        {
            get
            {
                // *** Start programmer edit section *** (Абитуриент.Город Get start)

                // *** End programmer edit section *** (Абитуриент.Город Get start)
                string result = this.fГород;
                // *** Start programmer edit section *** (Абитуриент.Город Get end)

                // *** End programmer edit section *** (Абитуриент.Город Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Абитуриент.Город Set start)

                // *** End programmer edit section *** (Абитуриент.Город Set start)
                this.fГород = value;
                // *** Start programmer edit section *** (Абитуриент.Город Set end)

                // *** End programmer edit section *** (Абитуриент.Город Set end)
            }
        }
        
        /// <summary>
        /// Адрес.
        /// </summary>
        // *** Start programmer edit section *** (Абитуриент.Адрес CustomAttributes)

        // *** End programmer edit section *** (Абитуриент.Адрес CustomAttributes)
        [StrLen(255)]
        public virtual string Адрес
        {
            get
            {
                // *** Start programmer edit section *** (Абитуриент.Адрес Get start)

                // *** End programmer edit section *** (Абитуриент.Адрес Get start)
                string result = this.fАдрес;
                // *** Start programmer edit section *** (Абитуриент.Адрес Get end)

                // *** End programmer edit section *** (Абитуриент.Адрес Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Абитуриент.Адрес Set start)

                // *** End programmer edit section *** (Абитуриент.Адрес Set start)
                this.fАдрес = value;
                // *** Start programmer edit section *** (Абитуриент.Адрес Set end)

                // *** End programmer edit section *** (Абитуриент.Адрес Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "АбитуриентE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View АбитуриентE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("АбитуриентE", typeof(IIS.Abiturient.Абитуриент));
                }
            }
            
            /// <summary>
            /// "АбитуриентL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View АбитуриентL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("АбитуриентL", typeof(IIS.Abiturient.Абитуриент));
                }
            }
        }
    }
}
