﻿// ListLoggingFromBlock.cs
//
// Author:
//       Sales Alencar <lopesdealencar@gmail.com>
//
// Copyright (c) 2018 MIT
using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Dharma.Core;
using Dharma.LoggingBlock.Models;

[assembly: InternalsVisibleTo("LoggingBlock.Component.Tests")]
[assembly: InternalsVisibleTo("LoggingBlock.Implementation")]
namespace Dharma.LoggingBlock.Components.Queries
{
	internal class ListLoggingFromBlockQuery : BaseQuery<LoggingBlockModel>
	{

		private readonly string _blockName;

		public ListLoggingFromBlockQuery(string blockName)
		{
			_blockName = blockName;
		}

		protected override Expression<Func<LoggingBlockModel, bool>> _filter => (t => t.BlockOrigin == _blockName);

		protected override string server => LoggingBlockQuery.Server;

		protected override int port => Convert.ToInt32(LoggingBlockQuery.Port);

		protected override string database => LoggingBlockQuery.Database;

		protected override string user => LoggingBlockQuery.User;

		protected override string pwd => LoggingBlockQuery.Pwd;

	}
}
