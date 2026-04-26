/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAllocationSummaryByBusinessRequest : AbstractModel
    {
        
        /// <summary>
        /// Quantity, with the maximum value of 1,000
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Pagination offset. If Offset is 0, it indicates the first page. If Limit is 100, then Offset is 100, and it indicates the second page. If Offset is 200, it indicates the third page, and so on.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Bill month, in the format of 2024-02, which is the current month by default if not provided
        /// 
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// Statistical period, with the enumerated values as follows:
        /// month - Month
        /// day - Day
        /// </summary>
        [JsonProperty("PeriodType")]
        public string PeriodType{ get; set; }

        /// <summary>
        /// Unique identifier of a billing unit, used for filtering
        /// 
        /// </summary>
        [JsonProperty("TreeNodeUniqKeys")]
        public string[] TreeNodeUniqKeys{ get; set; }

        /// <summary>
        /// Sorting type, with the enumerated values as follows:
        /// asc - Ascending
        /// desc - Descending
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }

        /// <summary>
        /// Sorting field, with the enumerated values as follows:
        /// GatherCashPayAmount - Collected fees (cash)
        /// GatherVoucherPayAmount - Collected fees (voucher)
        /// GatherIncentivePayAmount - Collected fees (free credit)
        /// GatherTransferPayAmount - Collected fees (royalty amount)
        /// AllocateCashPayAmount - Allocated fees (cash)
        /// AllocateVoucherPayAmount - Allocated fees (voucher)
        /// AllocateIncentivePayAmount - Allocated fees (free credit)
        /// AllocateTransferPayAmount - Allocated fees (royalty amount)
        /// TotalCashPayAmount - Total fees (cash)
        /// TotalVoucherPayAmount - Total fees (voucher)
        /// TotalIncentivePayAmount - Total fees (free credit)
        /// TotalTransferPayAmount - Total fees (royalty amount)
        /// GatherRealCost - Collected fees (discounted total)
        /// AllocateRealCost - Allocated fees (discounted total)
        /// RealTotalCost - Total fees (discounted total)
        /// BusinessCode - Product code
        /// Ratio - Proportion (discounted total)
        /// Trend - Month-on-month ratio (discounted total)
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// Date, used for filtering and provided when PeriodType is set to day
        /// </summary>
        [JsonProperty("BillDates")]
        public string[] BillDates{ get; set; }

        /// <summary>
        /// Product code, used for filtering
        /// </summary>
        [JsonProperty("BusinessCodes")]
        public string[] BusinessCodes{ get; set; }

        /// <summary>
        /// Fuzzy search criteria
        /// </summary>
        [JsonProperty("SearchKey")]
        [System.Obsolete]
        public string SearchKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "PeriodType", this.PeriodType);
            this.SetParamArraySimple(map, prefix + "TreeNodeUniqKeys.", this.TreeNodeUniqKeys);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamArraySimple(map, prefix + "BillDates.", this.BillDates);
            this.SetParamArraySimple(map, prefix + "BusinessCodes.", this.BusinessCodes);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
        }
    }
}

