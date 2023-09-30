using AutoEatery.Data.Models;
using AutoEatery.GraphQL.Types;
using AutoEatery.GraphQL.Types.Create;
using AutoEatery.GraphQL.Types.Update;
using GraphQL;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;

namespace AutoEatery.GraphQL.Mutations;

public sealed class EateryMutation : ObjectGraphType
{
    public EateryMutation(DbContext dbContext)
    {
        Create<Dish, DishType, CreateDishInputType>(dbContext);
        Create<Order, OrderType, CreateOrderInputType>(dbContext);
        Create<Ingredient, IngredientType, CreateIngredientInputType>(dbContext);
        Create<Supplier, SupplierType, CreateSupplierInputType>(dbContext);
        
        Update<Dish, DishType, UpdateDishInputType>(dbContext);
        Update<Order, OrderType, UpdateOrderInputType>(dbContext);
        Update<Ingredient, IngredientType, UpdateIngredientInputType>(dbContext);
        Update<Supplier, SupplierType, UpdateSupplierInputType>(dbContext);
        
        Delete<Dish, DishType>(dbContext);
        Delete<Order, OrderType>(dbContext);
        Delete<Ingredient, IngredientType>(dbContext);
        Delete<Supplier, SupplierType>(dbContext);
    }

    private void Create<E, O, I>(
        DbContext dbContext
    )
        where E : BaseEntity
        where O : ObjectGraphType<E>
        where I : InputObjectGraphType<E>
    {
        var entityName = typeof(E).Name;
        Field<O>($"create{entityName}")
            .Arguments(new QueryArgument<I> { Name = entityName.ToLower() })
            .ResolveAsync(async context =>
            {
                var entity = context.GetArgument<E>(entityName.ToLower());
                await dbContext.AddAsync(entity);
                await dbContext.SaveChangesAsync();
                return entity;
            });
    }

    private void Update<E, O, I>(
        DbContext dbContext
    )
        where E : BaseEntity
        where O : ObjectGraphType<E>
        where I : InputObjectGraphType<E>
    {
        var entityName = typeof(E).Name;
        Field<O>($"update{entityName}")
            .Arguments(new QueryArgument<I> { Name = entityName.ToLower() })
            .ResolveAsync(async context =>
            {
                var entity = context.GetArgument<E>(entityName.ToLower());
                var foundEntity = await dbContext.Set<E>().FirstOrDefaultAsync();
                if (foundEntity != null)
                {
                    dbContext.Entry(foundEntity).State = EntityState.Detached;
                    dbContext.Update(entity);
                }
                await dbContext.SaveChangesAsync();
                return foundEntity;
            });
    }

    private void Delete<E, O>(
        DbContext dbContext
    )
        where E : BaseEntity
        where O : ObjectGraphType<E>
    {
        var entityName = typeof(E).Name;
        Field<O>($"delete{entityName}")
            .Arguments(new QueryArgument<IntGraphType> { Name = "id" })
            .ResolveAsync(async context =>
            {
                var id = context.GetArgument<int>("id");
                var foundEntity = await dbContext.Set<E>().SingleAsync(e => e.Id == id);
                dbContext.Set<E>().Remove(foundEntity);
                await dbContext.SaveChangesAsync();
                return foundEntity;
            });
    }
}