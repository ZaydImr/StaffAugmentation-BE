﻿using Core.ViewModel;

namespace Business.IServices;

public interface ITypeService
{
    Task<IEnumerable<TypeViewModel>?> GetType();
    Task<TypeViewModel?> GetType(int Id);
    Task<TypeViewModel?> CreateType(TypeViewModel type);
    Task<TypeViewModel?> UpdateType(TypeViewModel type);
    Task<IEnumerable<TypeViewModel>?> DeleteType(int Id);
}
