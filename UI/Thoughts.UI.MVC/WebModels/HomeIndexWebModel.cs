﻿namespace Thoughts.UI.MVC.WebModels;

/// <summary> Вебмодель отображения данных на главной странице </summary>
public class HomeIndexWebModel
{
    /// <summary> Данные по публикациям на главной странице </summary>
    public IEnumerable<Domain.Base.Entities.Post> Posts { get; set; }
}
