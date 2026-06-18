using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using MedWise.Core.Interfaces;
using MedWise.Core.Models;
using MedWise.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace MedWise.Infrastructure.Repositories;

public class DrugInteractionRepository : Repository<DrugInteraction>, IDrugInteractionRepository, IRepository<DrugInteraction>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public int med1Id;

		public int med2Id;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public string ingredient1;

		public string ingredient2;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCheckIngredientInteractionAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<IngredientInteraction>> _003C_003Et__builder;

		public string ingredient1;

		public string ingredient2;

		public DrugInteractionRepository _003C_003E4__this;

		private TaskAwaiter<List<IngredientInteraction>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_039a: Unknown result type (might be due to invalid IL or missing references)
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected O, but got Unknown
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected O, but got Unknown
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Expected O, but got Unknown
			//IL_016d: Expected O, but got Unknown
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Expected O, but got Unknown
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Expected O, but got Unknown
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected O, but got Unknown
			//IL_0205: Expected O, but got Unknown
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected O, but got Unknown
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0234: Expected O, but got Unknown
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Expected O, but got Unknown
			//IL_0257: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Expected O, but got Unknown
			//IL_02a2: Expected O, but got Unknown
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Expected O, but got Unknown
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Expected O, but got Unknown
			//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Expected O, but got Unknown
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0325: Unknown result type (might be due to invalid IL or missing references)
			//IL_0334: Expected O, but got Unknown
			//IL_033a: Expected O, but got Unknown
			//IL_035b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Unknown result type (might be due to invalid IL or missing references)
			//IL_0368: Unknown result type (might be due to invalid IL or missing references)
			//IL_036d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DrugInteractionRepository drugInteractionRepository = _003C_003E4__this;
			global::System.Collections.Generic.IEnumerable<IngredientInteraction> result2;
			try
			{
				TaskAwaiter<List<IngredientInteraction>> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0
					{
						ingredient1 = ingredient1,
						ingredient2 = ingredient2
					};
					DbSet<IngredientInteraction> ingredientInteractions = drugInteractionRepository._context.IngredientInteractions;
					ParameterExpression val = Expression.Parameter(typeof(IngredientInteraction), "i");
					IIncludableQueryable<IngredientInteraction, ActiveIngredient> obj = EntityFrameworkQueryableExtensions.Include<IngredientInteraction, ActiveIngredient>((IQueryable<IngredientInteraction>)(object)ingredientInteractions, Expression.Lambda<Func<IngredientInteraction, ActiveIngredient>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(IngredientInteraction), "i");
					IIncludableQueryable<IngredientInteraction, ActiveIngredient> obj2 = EntityFrameworkQueryableExtensions.Include<IngredientInteraction, ActiveIngredient>((IQueryable<IngredientInteraction>)(object)obj, Expression.Lambda<Func<IngredientInteraction, ActiveIngredient>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(IngredientInteraction), "i");
					awaiter = EntityFrameworkQueryableExtensions.ToListAsync<IngredientInteraction>(Queryable.Where<IngredientInteraction>((IQueryable<IngredientInteraction>)(object)obj2, Expression.Lambda<Func<IngredientInteraction, bool>>((Expression)(object)Expression.OrElse((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Call((Expression)(object)Expression.Call((Expression)(object)Expression.Property((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression[])(object)new Expression[1] { (Expression)Expression.Call((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()) }), (Expression)(object)Expression.Call((Expression)(object)Expression.Call((Expression)(object)Expression.Property((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression[])(object)new Expression[1] { (Expression)Expression.Call((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()) })), (Expression)(object)Expression.AndAlso((Expression)(object)Expression.Call((Expression)(object)Expression.Call((Expression)(object)Expression.Property((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression[])(object)new Expression[1] { (Expression)Expression.Call((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()) }), (Expression)(object)Expression.Call((Expression)(object)Expression.Call((Expression)(object)Expression.Property((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression[])(object)new Expression[1] { (Expression)Expression.Call((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()) }))), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IngredientInteraction>>, _003CCheckIngredientInteractionAsync_003Ed__2>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<IngredientInteraction>>);
					num = (_003C_003E1__state = -1);
				}
				List<IngredientInteraction> result = awaiter.GetResult();
				result2 = (global::System.Collections.Generic.IEnumerable<IngredientInteraction>)result;
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCheckInteractionAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DrugInteraction> _003C_003Et__builder;

		public int med1Id;

		public int med2Id;

		public DrugInteractionRepository _003C_003E4__this;

		private TaskAwaiter<DrugInteraction?> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected O, but got Unknown
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DrugInteractionRepository drugInteractionRepository = _003C_003E4__this;
			DrugInteraction result2;
			try
			{
				TaskAwaiter<DrugInteraction> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0
					{
						med1Id = med1Id,
						med2Id = med2Id
					};
					DbSet<DrugInteraction> dbSet = drugInteractionRepository._dbSet;
					ParameterExpression val = Expression.Parameter(typeof(DrugInteraction), "d");
					awaiter = EntityFrameworkQueryableExtensions.FirstOrDefaultAsync<DrugInteraction>((IQueryable<DrugInteraction>)(object)dbSet, Expression.Lambda<Func<DrugInteraction, bool>>((Expression)(object)Expression.OrElse((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), (Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))))), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<DrugInteraction>, _003CCheckInteractionAsync_003Ed__1>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<DrugInteraction>);
					num = (_003C_003E1__state = -1);
				}
				DrugInteraction result = awaiter.GetResult();
				result2 = result;
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	public DrugInteractionRepository(ApplicationDbContext context)
		: base(context)
	{
	}

	[AsyncStateMachine(typeof(_003CCheckInteractionAsync_003Ed__1))]
	public async global::System.Threading.Tasks.Task<DrugInteraction?> CheckInteractionAsync(int med1Id, int med2Id)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.med1Id = med1Id;
		_003C_003Ec__DisplayClass1_.med2Id = med2Id;
		DbSet<DrugInteraction> dbSet = _dbSet;
		ParameterExpression val = Expression.Parameter(typeof(DrugInteraction), "d");
		return await EntityFrameworkQueryableExtensions.FirstOrDefaultAsync<DrugInteraction>((IQueryable<DrugInteraction>)(object)dbSet, Expression.Lambda<Func<DrugInteraction, bool>>((Expression)(object)Expression.OrElse((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), (Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))))), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken));
	}

	[AsyncStateMachine(typeof(_003CCheckIngredientInteractionAsync_003Ed__2))]
	public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<IngredientInteraction>> CheckIngredientInteractionAsync(string ingredient1, string ingredient2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.ingredient1 = ingredient1;
		_003C_003Ec__DisplayClass2_.ingredient2 = ingredient2;
		DbSet<IngredientInteraction> ingredientInteractions = _context.IngredientInteractions;
		ParameterExpression val = Expression.Parameter(typeof(IngredientInteraction), "i");
		IIncludableQueryable<IngredientInteraction, ActiveIngredient> obj = EntityFrameworkQueryableExtensions.Include<IngredientInteraction, ActiveIngredient>((IQueryable<IngredientInteraction>)(object)ingredientInteractions, Expression.Lambda<Func<IngredientInteraction, ActiveIngredient>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(IngredientInteraction), "i");
		IIncludableQueryable<IngredientInteraction, ActiveIngredient> obj2 = EntityFrameworkQueryableExtensions.Include<IngredientInteraction, ActiveIngredient>((IQueryable<IngredientInteraction>)(object)obj, Expression.Lambda<Func<IngredientInteraction, ActiveIngredient>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(IngredientInteraction), "i");
		return (global::System.Collections.Generic.IEnumerable<IngredientInteraction>)(await EntityFrameworkQueryableExtensions.ToListAsync<IngredientInteraction>(Queryable.Where<IngredientInteraction>((IQueryable<IngredientInteraction>)(object)obj2, Expression.Lambda<Func<IngredientInteraction, bool>>((Expression)(object)Expression.OrElse((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Call((Expression)(object)Expression.Call((Expression)(object)Expression.Property((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression[])(object)new Expression[1] { (Expression)Expression.Call((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()) }), (Expression)(object)Expression.Call((Expression)(object)Expression.Call((Expression)(object)Expression.Property((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression[])(object)new Expression[1] { (Expression)Expression.Call((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()) })), (Expression)(object)Expression.AndAlso((Expression)(object)Expression.Call((Expression)(object)Expression.Call((Expression)(object)Expression.Property((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression[])(object)new Expression[1] { (Expression)Expression.Call((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()) }), (Expression)(object)Expression.Call((Expression)(object)Expression.Call((Expression)(object)Expression.Property((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression[])(object)new Expression[1] { (Expression)Expression.Call((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), global::System.Array.Empty<Expression>()) }))), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)));
	}
}
