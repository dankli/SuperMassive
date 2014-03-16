﻿
namespace SuperMassive
{
    public interface IModelQuery<out TResult, in TModel>
    {
        TResult Execute(TModel model);
    }
}
