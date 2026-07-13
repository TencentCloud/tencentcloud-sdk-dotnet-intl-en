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

    public class BudgetExtend : AbstractModel
    {
        
        /// <summary>
        /// Budget Name
        /// </summary>
        [JsonProperty("BudgetName")]
        public string BudgetName{ get; set; }

        /// <summary>
        /// Budget limit
        /// </summary>
        [JsonProperty("BudgetQuota")]
        public string BudgetQuota{ get; set; }

        /// <summary>
        /// DAY, MONTH, QUARTER, YEAR
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

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
        /// Validity start time 2025-01-01
        /// </summary>
        [JsonProperty("PeriodBegin")]
        public string PeriodBegin{ get; set; }

        /// <summary>
        /// Validity end time 2025-12-01
        /// </summary>
        [JsonProperty("PeriodEnd")]
        public string PeriodEnd{ get; set; }

        /// <summary>
        /// COST,USAGE,RI,SP
        /// </summary>
        [JsonProperty("Dimensions")]
        public string Dimensions{ get; set; }

        /// <summary>
        /// FIX fixed value, CYCLE different value
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }

        /// <summary>
        /// threshold alert
        /// </summary>
        [JsonProperty("WarnJson")]
        public BudgetWarn[] WarnJson{ get; set; }

        /// <summary>
        /// User UIN
        /// </summary>
        [JsonProperty("PayerUin")]
        public ulong? PayerUin{ get; set; }

        /// <summary>
        /// fluctuation alert
        /// </summary>
        [JsonProperty("WaveThresholdJson")]
        public WaveThresholdForm[] WaveThresholdJson{ get; set; }

        /// <summary>
        /// Budget remark
        /// </summary>
        [JsonProperty("BudgetNote")]
        public string BudgetNote{ get; set; }

        /// <summary>
        /// Custom sending object information
        /// </summary>
        [JsonProperty("SendDetail")]
        public string SendDetail{ get; set; }

        /// <summary>
        /// Default uin sent
        /// </summary>
        [JsonProperty("DefaultMode")]
        public long? DefaultMode{ get; set; }

        /// <summary>
        /// CUS custom budget, ZERO_COST zero-cost budget template, BY_MONTH monthly cost budget template
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TemplateType")]
        public string TemplateType{ get; set; }

        /// <summary>
        /// (1, "Not over budget")
        /// (2, "Overspend")
        /// </summary>
        [JsonProperty("MoneyStatus")]
        public long? MoneyStatus{ get; set; }

        /// <summary>
        /// Reminder count
        /// </summary>
        [JsonProperty("RemindTimes")]
        public long? RemindTimes{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update budget time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Associated Id of the budget
        /// </summary>
        [JsonProperty("BudgetId")]
        public string BudgetId{ get; set; }

        /// <summary>
        /// NO_FORECAST (Not set)
        /// FORECAST_NO_DATA (Set up prediction but no data)
        /// FORECAST_HAS_DATA (Set up prediction with predictive data)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HasForecast")]
        public string HasForecast{ get; set; }

        /// <summary>
        /// predicted fee
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ForecastCost")]
        public string ForecastCost{ get; set; }

        /// <summary>
        /// Projection progress
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ForecastProgress")]
        public string ForecastProgress{ get; set; }

        /// <summary>
        /// actual fee
        /// </summary>
        [JsonProperty("RealCost")]
        public string RealCost{ get; set; }

        /// <summary>
        /// Custom send
        /// </summary>
        [JsonProperty("BudgetSendInfoForm")]
        public BudgetSendInfoDto[] BudgetSendInfoForm{ get; set; }

        /// <summary>
        /// current cycle
        /// </summary>
        [JsonProperty("CurDateDesc")]
        public string CurDateDesc{ get; set; }

        /// <summary>
        /// EXPIRED
        /// ACTIVE
        /// UNACTIVATED Invalid
        /// ACTIVATED To be effective
        /// </summary>
        [JsonProperty("BudgetStatus")]
        public string BudgetStatus{ get; set; }

        /// <summary>
        /// Budget dimension range condition
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DimensionsRange")]
        public BudgetConditionsForm DimensionsRange{ get; set; }

        /// <summary>
        /// Budget progress
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BudgetProgress")]
        public string BudgetProgress{ get; set; }

        /// <summary>
        /// Budget Type is set to budget planning and returns the budget limit
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BudgetQuotaJson")]
        public BudgetPlan[] BudgetQuotaJson{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BudgetName", this.BudgetName);
            this.SetParamSimple(map, prefix + "BudgetQuota", this.BudgetQuota);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "BillType", this.BillType);
            this.SetParamSimple(map, prefix + "FeeType", this.FeeType);
            this.SetParamSimple(map, prefix + "PeriodBegin", this.PeriodBegin);
            this.SetParamSimple(map, prefix + "PeriodEnd", this.PeriodEnd);
            this.SetParamSimple(map, prefix + "Dimensions", this.Dimensions);
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
            this.SetParamArrayObj(map, prefix + "WarnJson.", this.WarnJson);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamArrayObj(map, prefix + "WaveThresholdJson.", this.WaveThresholdJson);
            this.SetParamSimple(map, prefix + "BudgetNote", this.BudgetNote);
            this.SetParamSimple(map, prefix + "SendDetail", this.SendDetail);
            this.SetParamSimple(map, prefix + "DefaultMode", this.DefaultMode);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "MoneyStatus", this.MoneyStatus);
            this.SetParamSimple(map, prefix + "RemindTimes", this.RemindTimes);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "BudgetId", this.BudgetId);
            this.SetParamSimple(map, prefix + "HasForecast", this.HasForecast);
            this.SetParamSimple(map, prefix + "ForecastCost", this.ForecastCost);
            this.SetParamSimple(map, prefix + "ForecastProgress", this.ForecastProgress);
            this.SetParamSimple(map, prefix + "RealCost", this.RealCost);
            this.SetParamArrayObj(map, prefix + "BudgetSendInfoForm.", this.BudgetSendInfoForm);
            this.SetParamSimple(map, prefix + "CurDateDesc", this.CurDateDesc);
            this.SetParamSimple(map, prefix + "BudgetStatus", this.BudgetStatus);
            this.SetParamObj(map, prefix + "DimensionsRange.", this.DimensionsRange);
            this.SetParamSimple(map, prefix + "BudgetProgress", this.BudgetProgress);
            this.SetParamArrayObj(map, prefix + "BudgetQuotaJson.", this.BudgetQuotaJson);
        }
    }
}

