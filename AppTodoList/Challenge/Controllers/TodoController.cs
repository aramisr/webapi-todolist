using Api.Controllers;
using Application.UseCases.Todo.Commands.AddItemList;
using Application.UseCases.Todo.Queries.GetItemList;
using Application.UseCases.Todo.Queries.GetTodoList;
using Application.UseCases.Todo.Commands.UpdateItemList;
using Application.UseCases.Todo.Commands.RemoveItemList;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Controllers
{
    public class TodoController : BaseController
    {
        [HttpGet]
        [Route("GetTodoList")]
        [Produces(typeof(GetTodoListQueryDto))]
        [ActionName(nameof(GetTodoList))]
        public async Task<IActionResult> GetTodoList()
        {
            var query = new GetTodoListQuery();
            var result = await this.Mediator.Send(query);
            return this.FromResult(result);
        }

        [HttpGet]
        [Route("GetItemById")]
        [Produces(typeof(GetItemListQueryDto))]
        [ActionName(nameof(GetById))]
        public async Task<IActionResult> GetById([FromQuery] GetItemListQueryModel model)
        {
            var query = this.Mapper.Map <GetItemListQuery>(model);
            var result = await this.Mediator.Send(query);
            return this.FromResult(result);
        }

        [HttpPost]
        [Route("AddItem")]
        [Produces(typeof(AddItemListCommandDto))]
        [ActionName(nameof(InsertItem))]
        public async Task<IActionResult> InsertItem(AddItemListCommandModel model)
        {
            var command = this.Mapper.Map<AddItemListCommand>(model);
            var result = await this.Mediator.Send(command);
            return this.FromResult(result);
        }
        [HttpPut]
        [Route("UpdateItem")]
        [Produces(typeof(UpdateItemListCommandDto))]
        [ActionName(nameof(UpdateItem))]
        public async Task<IActionResult> UpdateItem(UpdateItemListCommandModel model)
        {
            var command = this.Mapper.Map<UpdateItemListCommand>(model);
            var result = await this.Mediator.Send(command);
            return this.FromResult(result);
        }

        [HttpDelete]
        [Route("DeleteItem")]
        [Produces(typeof(RemoveItemListCommand))]
        [ActionName(nameof(DeleteItem))]
        public async Task<IActionResult> DeleteItem(RemoveItemListCommandModel model)
        {
            var command = this.Mapper.Map<RemoveItemListCommand>(model);
            var result = await this.Mediator.Send(command);
            return this.FromResult(result);
        }
    }
}
