﻿using StockTradingAnalysis.Interfaces.Queries;
using System.Collections.Generic;

namespace StockTradingAnalysis.Domain.CQRS.Query.Queries
{
    public class TransactionTagAllQuery : IQuery<IEnumerable<string>>
    {
    }
}