/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BusinessInfo : AbstractModel
    {
        
        /// <summary>
        /// ProductNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BusinessCodeName")]
        public string BusinessCodeName{ get; set; }

        /// <summary>
        /// Product codeNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// Original price
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginalCost")]
        public string OriginalCost{ get; set; }

        /// <summary>
        /// Voucher amount
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VoucherPayAmount")]
        public string VoucherPayAmount{ get; set; }

        /// <summary>
        /// Daily deduction
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RICost")]
        public string RICost{ get; set; }

        /// <summary>
        /// Total amount
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessCodeName", this.BusinessCodeName);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "OriginalCost", this.OriginalCost);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "RICost", this.RICost);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
        }
    }
}

