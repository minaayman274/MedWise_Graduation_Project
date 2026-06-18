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
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MedWise.Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public int id;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CAddAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public T entity;

		public Repository<T> _003C_003E4__this;

		private ValueTaskAwaiter<EntityEntry<T>> _003C_003Eu__1;

		private TaskAwaiter<int> _003C_003Eu__2;

		private unsafe void MoveNext()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Repository<T> repository = _003C_003E4__this;
			T result;
			try
			{
				TaskAwaiter<int> awaiter;
				ValueTaskAwaiter<EntityEntry<T>> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<int>);
						num = (_003C_003E1__state = -1);
						goto IL_0105;
					}
					entity.CreatedAt = global::System.DateTime.UtcNow;
					awaiter2 = ((global::System.Threading.Tasks.ValueTask<EntityEntry<EntityEntry<T>>>)repository._dbSet.AddAsync(entity, default(CancellationToken))).GetAwaiter();
					if (!((ValueTaskAwaiter<EntityEntry<EntityEntry<T>>>*)(&awaiter2))->IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<EntityEntry<T>>, _003CAddAsync_003Ed__5>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(ValueTaskAwaiter<EntityEntry<T>>);
					num = (_003C_003E1__state = -1);
				}
				((ValueTaskAwaiter<EntityEntry<EntityEntry<T>>>*)(&awaiter2))->GetResult();
				awaiter = ((DbContext)repository._context).SaveChangesAsync(default(CancellationToken)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__2 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, _003CAddAsync_003Ed__5>(ref awaiter, ref this);
					return;
				}
				goto IL_0105;
				IL_0105:
				awaiter.GetResult();
				result = entity;
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDeleteAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Repository<T> _003C_003E4__this;

		public int id;

		private TaskAwaiter<T?> _003C_003Eu__1;

		private TaskAwaiter<int> _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Repository<T> repository = _003C_003E4__this;
			try
			{
				TaskAwaiter<int> awaiter;
				TaskAwaiter<T> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<int>);
						num = (_003C_003E1__state = -1);
						goto IL_010e;
					}
					awaiter2 = repository.GetByIdAsync(id).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<T>, _003CDeleteAsync_003Ed__7>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<T>);
					num = (_003C_003E1__state = -1);
				}
				T result = awaiter2.GetResult();
				T val = result;
				if (val != null)
				{
					val.IsDeleted = true;
					val.UpdatedAt = global::System.DateTime.UtcNow;
					awaiter = ((DbContext)repository._context).SaveChangesAsync(default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<int>, _003CDeleteAsync_003Ed__7>(ref awaiter, ref this);
						return;
					}
					goto IL_010e;
				}
				goto end_IL_000e;
				IL_010e:
				awaiter.GetResult();
				end_IL_000e:;
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CExistsAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public int id;

		public Repository<T> _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Repository<T> repository = _003C_003E4__this;
			bool result2;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0
					{
						id = id
					};
					DbSet<T> dbSet = repository._dbSet;
					ParameterExpression val = Expression.Parameter(typeof(T), "e");
					awaiter = EntityFrameworkQueryableExtensions.AnyAsync<T>((IQueryable<T>)(object)dbSet, Expression.Lambda<Func<T, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass8_, typeof(_003C_003Ec__DisplayClass8_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ec__DisplayClass8_0).TypeHandle))), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _003CExistsAsync_003Ed__8>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = (_003C_003E1__state = -1);
				}
				bool result = awaiter.GetResult();
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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CGetAllAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<T>> _003C_003Et__builder;

		public Repository<T> _003C_003E4__this;

		private TaskAwaiter<List<T>> _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Repository<T> repository = _003C_003E4__this;
			global::System.Collections.Generic.IEnumerable<T> result2;
			try
			{
				TaskAwaiter<List<T>> awaiter;
				if (num != 0)
				{
					awaiter = ((global::System.Threading.Tasks.Task<List<List<T>>>)(object)EntityFrameworkQueryableExtensions.ToListAsync<T>((IQueryable<T>)(object)repository._dbSet, default(CancellationToken))).GetAwaiter();
					if (!((TaskAwaiter<List<List<T>>>*)(&awaiter))->IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						global::System.Runtime.CompilerServices.Unsafe.As<AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<T>>, AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>>>>(ref _003C_003Et__builder).AwaitUnsafeOnCompleted<TaskAwaiter<List<T>>, _003CGetAllAsync_003Ed__4>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<T>>);
					num = (_003C_003E1__state = -1);
				}
				List<T> result = ((TaskAwaiter<List<List<T>>>*)(&awaiter))->GetResult();
				result2 = (global::System.Collections.Generic.IEnumerable<T>)result;
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				global::System.Runtime.CompilerServices.Unsafe.As<AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<T>>, AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>>>>(ref _003C_003Et__builder).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			global::System.Runtime.CompilerServices.Unsafe.As<AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<T>>, AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>>>>(ref _003C_003Et__builder).SetResult((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>>)result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			global::System.Runtime.CompilerServices.Unsafe.As<AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<T>>, AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>>>>(ref _003C_003Et__builder).SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CGetByIdAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public Repository<T> _003C_003E4__this;

		public int id;

		private ValueTaskAwaiter<T?> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Repository<T> repository = _003C_003E4__this;
			T result2;
			try
			{
				ValueTaskAwaiter<T> awaiter;
				if (num != 0)
				{
					awaiter = repository._dbSet.FindAsync(new object[1] { id }).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<T>, _003CGetByIdAsync_003Ed__3>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ValueTaskAwaiter<T>);
					num = (_003C_003E1__state = -1);
				}
				T result = awaiter.GetResult();
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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CUpdateAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public T entity;

		public Repository<T> _003C_003E4__this;

		private TaskAwaiter<int> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Repository<T> repository = _003C_003E4__this;
			try
			{
				TaskAwaiter<int> awaiter;
				if (num != 0)
				{
					entity.UpdatedAt = global::System.DateTime.UtcNow;
					repository._dbSet.Update(entity);
					awaiter = ((DbContext)repository._context).SaveChangesAsync(default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<int>, _003CUpdateAsync_003Ed__6>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<int>);
					num = (_003C_003E1__state = -1);
				}
				awaiter.GetResult();
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
		}
	}

	protected readonly ApplicationDbContext _context;

	protected readonly DbSet<T> _dbSet;

	public Repository(ApplicationDbContext context)
	{
		_context = context;
		_dbSet = ((DbContext)context).Set<T>();
	}

	[AsyncStateMachine(typeof(Repository<>._003CGetByIdAsync_003Ed__3))]
	public virtual async global::System.Threading.Tasks.Task<T?> GetByIdAsync(int id)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return await _dbSet.FindAsync(new object[1] { id });
	}

	[AsyncStateMachine(typeof(Repository<>._003CGetAllAsync_003Ed__4))]
	public virtual async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<T>> GetAllAsync()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return (global::System.Collections.Generic.IEnumerable<T>)(await (global::System.Threading.Tasks.Task<List<List<T>>>)(object)EntityFrameworkQueryableExtensions.ToListAsync<T>((IQueryable<T>)(object)_dbSet, default(CancellationToken)));
	}

	[AsyncStateMachine(typeof(Repository<>._003CAddAsync_003Ed__5))]
	public virtual async global::System.Threading.Tasks.Task<T> AddAsync(T entity)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		entity.CreatedAt = global::System.DateTime.UtcNow;
		await (global::System.Threading.Tasks.ValueTask<EntityEntry<EntityEntry<T>>>)_dbSet.AddAsync(entity, default(CancellationToken));
		await ((DbContext)_context).SaveChangesAsync(default(CancellationToken));
		return entity;
	}

	[AsyncStateMachine(typeof(Repository<>._003CUpdateAsync_003Ed__6))]
	public virtual global::System.Threading.Tasks.Task UpdateAsync(T entity)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CUpdateAsync_003Ed__6 _003CUpdateAsync_003Ed__ = default(_003CUpdateAsync_003Ed__6);
		_003CUpdateAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CUpdateAsync_003Ed__._003C_003E4__this = this;
		_003CUpdateAsync_003Ed__.entity = entity;
		_003CUpdateAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CUpdateAsync_003Ed__._003C_003Et__builder)).Start<_003CUpdateAsync_003Ed__6>(ref _003CUpdateAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CUpdateAsync_003Ed__._003C_003Et__builder)).Task;
	}

	[AsyncStateMachine(typeof(Repository<>._003CDeleteAsync_003Ed__7))]
	public virtual global::System.Threading.Tasks.Task DeleteAsync(int id)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CDeleteAsync_003Ed__7 _003CDeleteAsync_003Ed__ = default(_003CDeleteAsync_003Ed__7);
		_003CDeleteAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CDeleteAsync_003Ed__._003C_003E4__this = this;
		_003CDeleteAsync_003Ed__.id = id;
		_003CDeleteAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CDeleteAsync_003Ed__._003C_003Et__builder)).Start<_003CDeleteAsync_003Ed__7>(ref _003CDeleteAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CDeleteAsync_003Ed__._003C_003Et__builder)).Task;
	}

	[AsyncStateMachine(typeof(Repository<>._003CExistsAsync_003Ed__8))]
	public async global::System.Threading.Tasks.Task<bool> ExistsAsync(int id)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.id = id;
		DbSet<T> dbSet = _dbSet;
		ParameterExpression val = Expression.Parameter(typeof(T), "e");
		return await EntityFrameworkQueryableExtensions.AnyAsync<T>((IQueryable<T>)(object)dbSet, Expression.Lambda<Func<T, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass8_, typeof(_003C_003Ec__DisplayClass8_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ec__DisplayClass8_0).TypeHandle))), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken));
	}
}
