using Application.UseCases.Todo.Commands.AddItemList;
using Application.UseCases.Todo.Commands.RemoveItemList;
using Application.UseCases.Todo.Commands.UpdateItemList;
using Application.UseCases.Todo.Queries.GetItemList;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<GetItemListQueryModel, GetItemListQuery>();
            this.CreateMap<AddItemListCommandModel, AddItemListCommand>();
            this.CreateMap<UpdateItemListCommandModel, UpdateItemListCommand>();
            this.CreateMap<RemoveItemListCommandModel, RemoveItemListCommand>();
        }
    }
}
