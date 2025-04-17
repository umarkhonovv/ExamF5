﻿using ToDoList.Bll.DTOs;

namespace ToDoList.Bll.Services
{
    public interface IToDoItemService
    {
        Task<List<ToDoItemGetDto>> GetByDueDateAsync(DateTime dueDate);
        Task<ToDoItemGetDto> GetToDoItemByIdAsync(long id);
        Task<List<ToDoItemGetDto>> GetAllToDoItemsAsync(int skip, int take);
        Task<long> AddToDoItemAsync(ToDoItemCreateDto toDoItem);
        Task DeleteToDoItemByIdAsync(long id);
        Task UpdateToDoItemAsync(ToDoItemUpdateDto newItem);
        Task<List<ToDoItemGetDto>> GetCompletedAsync(int skip, int take);
        Task<List<ToDoItemGetDto>> GetIncompleteAsync(int skip, int take);

    }
}
