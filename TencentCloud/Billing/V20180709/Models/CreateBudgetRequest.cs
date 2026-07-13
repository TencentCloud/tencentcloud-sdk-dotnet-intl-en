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

    public class CreateBudgetRequest : AbstractModel
    {
        
        /// <summary>
        /// Budget Name
        /// </summary>
        [JsonProperty("BudgetName")]
        public string BudgetName{ get; set; }

        /// <summary>
        /// DAY, MONTH, QUARTER, YEAR
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// Validity start time 2025-01-01 (Period: day) / 2025-01 (Period: month)
        /// </summary>
        [JsonProperty("PeriodBegin")]
        public string PeriodBegin{ get; set; }

        /// <summary>
        /// Validity end time 2025-12-01 (Period: day) / 2025-12 (Cycle: month)
        /// </summary>
        [JsonProperty("PeriodEnd")]
        public string PeriodEnd{ get; set; }

        /// <summary>
        /// FIX Fixed Budget, CYCLE Budget Planning
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }

        /// <summary>
        /// Budget amount limit
        /// Pass a fixed value when the schedule type is FIX (fixed budget).
        /// When the schedule type is CYCLE (budget planning), pass [{"dateDesc":"2025-07","quota":"1000"},{"dateDesc":"2025-08","quota":"2000"}].
        /// </summary>
        [JsonProperty("BudgetQuota")]
        public string BudgetQuota{ get; set; }

        /// <summary>
        /// BILL System bill, CONSUMPTION Consumption bill
        /// </summary>
        [JsonProperty("BillType")]
        public string BillType{ get; set; }

        /// <summary>
        /// COST Original price, REAL_COST Actual fee, CASH Cash, INCENTIVE Free credit, VOUCHER Voucher, TRANSFER Allocated fees (royalty amount), TAX Tax, AMOUNT_BEFORE_TAX Cash payment (before tax)
        /// </summary>
        [JsonProperty("FeeType")]
        public string FeeType{ get; set; }

        /// <summary>
        /// Threshold alert
        /// </summary>
        [JsonProperty("WarnJson")]
        public BudgetWarn[] WarnJson{ get; set; }

        /// <summary>
        /// Budget remark
        /// </summary>
        [JsonProperty("BudgetNote")]
        public string BudgetNote{ get; set; }

        /// <summary>
        /// Budget Dimension Range Condition
        /// </summary>
        [JsonProperty("DimensionsRange")]
        public BudgetConditionsForm DimensionsRange{ get; set; }

        /// <summary>
        /// Fluctuation alert
        /// </summary>
        [JsonProperty("WaveThresholdJson")]
        public WaveThresholdForm[] WaveThresholdJson{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BudgetName", this.BudgetName);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "PeriodBegin", this.PeriodBegin);
            this.SetParamSimple(map, prefix + "PeriodEnd", this.PeriodEnd);
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
            this.SetParamSimple(map, prefix + "BudgetQuota", this.BudgetQuota);
            this.SetParamSimple(map, prefix + "BillType", this.BillType);
            this.SetParamSimple(map, prefix + "FeeType", this.FeeType);
            this.SetParamArrayObj(map, prefix + "WarnJson.", this.WarnJson);
            this.SetParamSimple(map, prefix + "BudgetNote", this.BudgetNote);
            this.SetParamObj(map, prefix + "DimensionsRange.", this.DimensionsRange);
            this.SetParamArrayObj(map, prefix + "WaveThresholdJson.", this.WaveThresholdJson);
        }
    }
}

