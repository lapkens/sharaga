using Microsoft.VisualBasic;

namespace ClassLibrary8
{
    /// <summary>
    /// описание работы модуля по учету заявок на ремонт оборудования
    /// </summary>
    public class RequestRemont
    {
        /// <summary>
        /// Идентификатор заявки на ремонт.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Оборудование, требующее ремонта.
        /// </summary>
        public string Equipment { get; private set; }
        /// <summary>
        /// Серийный номер оборудования.
        /// </summary>
        public string SerialNubmer { get; private set; }
        /// <summary>
        /// Описание неисправности.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public int ClientId { get; private set; }
        /// <summary>
        /// Приоритет заявки.
        /// </summary>
        public string Priority { get; private set; }
        /// <summary>
        /// Дата создания заявки.
        /// </summary>
        public DateTime CreateAt { get; private set; }
        /// <summary>
        /// Дата последнего обновления заявки.
        /// </summary>
        public DateTime UpdateAt { get; private set; }
        /// <summary>
        /// Дата завершения ремонта.
        /// </summary>
        public DateTime FinishAt { get; private set; }
        /// <summary>
        /// Статус заявки (например, "В обработке", "Завершена").
        /// </summary>
        public string Status { get; private set; }

        /// <summary>
        /// Конструктор класса RequestRemont.
        /// </summary>
        /// <param name="id">Идентификатор заявки.</param>
        /// <param name="ClientId">Идентификатор клиента.</param>
        public RequestRemont(int id, int ClientId)
        {
            ID = id;
            Equipment = string.Empty;
            SerialNubmer = string.Empty;
            Description = string.Empty;
            ClientId = ClientId;
            Priority = string.Empty;
            CreateAt = DateTime.MinValue;
            UpdateAt = DateTime.Now;
            FinishAt = DateTime.MinValue;
            Status = string.Empty;
        }

    }
    public class RequestRegistary
    {
        /// <summary>
        /// Идентификатор заявки.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Оборудование, по которому создана заявка.
        /// </summary>
        public string Equipment { get; private set; }
        /// <summary>
        /// Серийный номер оборудования.
        /// </summary>
        public string SerialNubmer { get; private set; }
        /// <summary>
        /// Описание заявки.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public int ClientId { get; private set; }
        /// <summary>
        /// Приоритет заявки.
        /// </summary>
        public string Priority { get; private set; }
        /// <summary>
        /// Дата создания заявки.
        /// </summary>
        public DateTime CreateAt { get; private set; }
        /// <summary>
        /// Статус заявки.
        /// </summary>
        public string Status { get; private set; }

        /// <summary>
        /// Конструктор класса RequestRegistary.
        /// </summary>
        /// <param name="id">Идентификатор заявки.</param>
        /// <param name="ClientId">Идентификатор клиента.</param>
        public RequestRegistary(int id, int ClientId)
        {
            ID = id;
            Equipment = string.Empty;
            SerialNubmer = string.Empty;
            Description = string.Empty;
            ClientId = ClientId;
            Priority = string.Empty;
            CreateAt = DateTime.MinValue;
            Status = string.Empty;
        }
    }


    public class RequestProcessor
    {
        /// <summary>
        /// Исполнитель заявки.
        /// </summary>
        public string Executor { get; private set; }
        /// <summary>
        /// Идентификатор заявки.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Оборудование, требующее обработки.
        /// </summary>
        public string Equipment { get; private set; }
        /// <summary>
        /// Серийный номер оборудования.
        /// </summary>
        public string SerialNubmer { get; private set; }
        /// <summary>
        /// Описание заявки.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public int ClientId { get; private set; }
        /// <summary>
        /// Приоритет заявки.
        /// </summary>
        public string Priority { get; private set; }
        /// <summary>
        /// Дата последнего обновления заявки.
        /// </summary>
        public DateTime UpdateAt { get; private set; }
        /// <summary>
        /// Статус заявки.
        /// </summary>
        public string Status { get; private set; }
        /// <summary>
        /// Конструктор класса RequestProcessor.
        /// </summary>
        /// <param name="id">Идентификатор заявки.</param>
        /// <param name="ClientId">Идентификатор клиента.</param>
        public RequestProcessor(int id, int ClientId)
        {
            ID = id;
            Equipment = string.Empty;
            SerialNubmer = string.Empty;
            Description = string.Empty;
            ClientId = ClientId;
            Priority = string.Empty;
            UpdateAt = DateTime.Now;
            Status = string.Empty;
            Executor = string.Empty;
        }
    }
    public class RequestExecute
    {
        /// <summary>
        /// Исполнитель заявки.
        /// </summary>
        public string Executor { get; private set; }
        /// <summary>
        /// Идентификатор заявки.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Оборудование, по которому выполняется заявка.
        /// </summary>
        public string Equipment { get; private set; }
        /// <summary>
        /// Серийный номер оборудования.
        /// </summary>
        public string SerialNubmer { get; private set; }
        /// <summary>
        /// Описание заявки.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public int ClientId { get; private set; }
        /// <summary>
        /// Приоритет заявки.
        /// </summary>
        public string Priority { get; private set; }
        /// <summary>
        /// Дата последнего обновления заявки.
        /// </summary>
        public DateTime UpdateAt { get; private set; }
        /// <summary>
        /// Статус заявки.
        /// </summary>
        public string Status { get; private set; }
        /// <summary>
        /// Необходимые изменения.
        /// </summary>
        public string Change { get; private set; }
        /// <summary>
        /// Используемые компоненты.
        /// </summary>
        public string Part { get; private set; }

        /// <summary>
        /// Конструктор класса RequestExecute.
        /// </summary>
        /// <param name="id">Идентификатор заявки.</param>
        /// <param name="ClientId">Идентификатор клиента.</param>
        public RequestExecute(int id, int ClientId)
        {
            ID = id;
            Equipment = string.Empty;
            SerialNubmer = string.Empty;
            Description = string.Empty;
            ClientId = ClientId;
            Priority = string.Empty;
            UpdateAt = DateTime.Now;
            Status = string.Empty;
            Executor = string.Empty;
            Change = string.Empty;
            Part = string.Empty;
        }
    }


    public class Report

    {
        /// <summary>
        /// Исполнитель заявки.
        /// </summary>
        public string Executor { get; private set; }
        /// <summary>
        /// Идентификатор заявки.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Оборудование, по которому составлен отчет.
        /// </summary>
        public string Equipment { get; private set; }
        /// <summary>
        /// Серийный номер оборудования.
        /// </summary>
        public string SerialNubmer { get; private set; }
        /// <summary>
        /// Описание заявки.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public int ClientId { get; private set; }
        /// <summary>
        /// Приоритет заявки.
        /// </summary>
        public string Priority { get; private set; }
        /// <summary>
        /// Дата создания заявки.
        /// </summary>
        public DateTime CreateAt { get; private set; }
        /// <summary>
        /// Дата последнего обновления заявки.
        /// </summary>
        public DateTime UpdateAt { get; private set; }
        /// <summary>
        /// Дата завершения заявки.
        /// </summary>
        public DateTime FinishAt { get; private set; }
        /// <summary>
        /// Статус заявки.
        /// </summary>
        public string Status { get; private set; }
        /// <summary>
        /// Выполненные изменения.
        /// </summary>
        public string Change { get; private set; }
        /// <summary>
        /// Стоимость ремонта.
        /// </summary>
        public int Cost { get; private set; }
        /// <summary>
        /// Используемые компоненты.
        /// </summary>
        public string Part { get; private set; }

        /// <summary>
        /// Конструктор класса Report.
        /// </summary>
        /// <param name="id">Идентификатор заявки.</param>
        /// <param name="ClientId">Идентификатор клиента.</param>
        /// <param name="Cost">Стоимость ремонта.</param>
        public Report(int id, int ClientId, int Cost)
        {
            ID = id;
            Equipment = string.Empty;
            SerialNubmer = string.Empty;
            Description = string.Empty;
            ClientId = ClientId;
            Priority = string.Empty;
            CreateAt = DateTime.MinValue;
            UpdateAt = DateTime.Now;
            FinishAt = DateTime.MinValue;
            Status = string.Empty;
            Executor = string.Empty;
            Change = string.Empty;
            Part = string.Empty;
            Cost = Cost;
        }
    }
    public class Monitoring
    {
        /// <summary>
        /// Исполнитель заявки.
        /// </summary>
        public string Executor { get; private set; }
        /// <summary>
        /// Идентификатор заявки.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Оборудование, по которому ведется мониторинг.
        /// </summary>
        public string Equipment { get; private set; }
        /// <summary>
        /// Серийный номер оборудования.
        /// </summary>
        public string SerialNubmer { get; private set; }
        /// <summary>
        /// Описание заявки.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public int ClientId { get; private set; }
        /// <summary>
        /// Приоритет заявки.
        /// </summary>
        public string Priority { get; private set; }
        /// <summary>
        /// Дата создания заявки.
        /// </summary>
        public DateTime CreateAt { get; private set; }
        /// <summary>
        /// Дата последнего обновления заявки.
        /// </summary>
        public DateTime UpdateAt { get; private set; }
        /// <summary>
        /// Дата завершения заявки.
        /// </summary>
        public DateTime FinishAt { get; private set; }
        /// <summary>
        /// Статус заявки.
        /// </summary>
        public string Status { get; private set; }
        /// <summary>
        /// Выполненные изменения.
        /// </summary>
        public string Change { get; private set; }
        /// <summary>
        /// Стоимость ремонта.
        /// </summary>
        public int Cost { get; private set; }
        /// <summary>
        /// Используемые компоненты.
        /// </summary>
        public string Part { get; private set; }
        /// <summary>
        /// Рейтинг заявки.
        /// </summary>
        public int Rating { get; private set; }

        /// <summary>
        /// Конструктор класса Monitoring.
        /// </summary>
        /// <param name="id">Идентификатор заявки.</param>
        /// <param name="ClientId">Идентификатор клиента.</param>
        /// <param name="Cost">Стоимость ремонта.</param>
        /// <param name="Rating">Рейтинг заявки.</param>
        public Monitoring(int id, int ClientId, int Cost, int Rating)
        {
            ID = id;
            Equipment = string.Empty;
            SerialNubmer = string.Empty;
            Description = string.Empty;
            ClientId = ClientId;
            Priority = string.Empty;
            CreateAt = DateTime.MinValue;
            UpdateAt = DateTime.Now;
            FinishAt = DateTime.MinValue;
            Status = string.Empty;
            Executor = string.Empty;
            Change = string.Empty;
            Part = string.Empty;
            Cost = Cost;
            Rating = Rating;
        }

    }
    public class Client
    {
        /// <summary>
        /// Уникальный идентификатор клиента.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Серийный номер заявки, связанной с клиентом.
        /// </summary>
        public string SerialNubmer { get; private set; }
        /// <summary>
        /// Идентификатор клиента (возможно, дублирует ID).
        /// </summary>
        public int ClientId { get; private set; }
        /// <summary>
        /// Имя клиента.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Фамилия клиента.
        /// </summary>
        public string Surname { get; private set; }
        /// <summary>
        /// Номер телефона клиента.
        /// </summary>
        public int PhoneNumber { get; private set; }

        /// <summary>
        /// Конструктор класса Client.
        /// </summary>
        /// <param name="id">Уникальный идентификатор клиента.</param>
        /// <param name="ClientId">Идентификатор клиента (возможно, дублирует ID).</param>
        /// <param name="PhoneNumber">Номер телефона клиента.</param>
        public Client(int id, int ClientId, int PhoneNumber)
        {
            ID = id;
            SerialNubmer = string.Empty;
            Name = string.Empty;
            Surname = string.Empty;
            ClientId = ClientId;
            PhoneNumber = PhoneNumber;
        }

    }
    public class Executor
    {
        /// <summary>
        /// Уникальный идентификатор исполнителя.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Серийный номер заявки, обработанной исполнителем.
        /// </summary>
        public string SerialNubmer { get; private set; }
        /// <summary>
        /// Идентификатор клиента, заявка которого обработана исполнителем.
        /// </summary>
        public int ClientId { get; private set; }
        /// <summary>
        /// Имя исполнителя.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Фамилия исполнителя.
        /// </summary>
        public string Surname { get; private set; }

        /// <summary>
        /// Конструктор класса Executor.
        /// </summary>
        /// <param name="id">Уникальный идентификатор исполнителя.</param>
        /// <param name="ClientId">Идентификатор клиента.</param>
        public Executor(int id, int ClientId)
        {
            ID = id;
            SerialNubmer = string.Empty;
            Name = string.Empty;
            Surname = string.Empty;
            ClientId = ClientId;
        }
    }

}

