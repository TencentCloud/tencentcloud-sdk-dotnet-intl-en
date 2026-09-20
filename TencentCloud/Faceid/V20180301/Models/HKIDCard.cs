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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HKIDCard : AbstractModel
    {
        
        /// <summary>
        /// Chinese name
        /// </summary>
        [JsonProperty("CnName")]
        public string CnName{ get; set; }

        /// <summary>
        /// English name
        /// </summary>
        [JsonProperty("EnName")]
        public string EnName{ get; set; }

        /// <summary>
        /// Chinese name telegraph code
        /// </summary>
        [JsonProperty("TelexCode")]
        public string TelexCode{ get; set; }

        /// <summary>
        /// Gender: "M" (male) or "F" (female)
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// Permanent resident ID card: 0: non-permanent; 1: permanent; -1: unknown
        /// </summary>
        [JsonProperty("Permanent")]
        public string Permanent{ get; set; }

        /// <summary>
        /// Identity number
        /// </summary>
        [JsonProperty("IdNum")]
        public string IdNum{ get; set; }

        /// <summary>
        /// Document symbol, the symbol below the date of birth, for example, "***AZ"
        /// </summary>
        [JsonProperty("Symbol")]
        public string Symbol{ get; set; }

        /// <summary>
        /// Date of first issue
        /// </summary>
        [JsonProperty("FirstIssueDate")]
        public string FirstIssueDate{ get; set; }

        /// <summary>
        /// Most recent date of issue
        /// </summary>
        [JsonProperty("CurrentIssueDate")]
        public string CurrentIssueDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CnName", this.CnName);
            this.SetParamSimple(map, prefix + "EnName", this.EnName);
            this.SetParamSimple(map, prefix + "TelexCode", this.TelexCode);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "Permanent", this.Permanent);
            this.SetParamSimple(map, prefix + "IdNum", this.IdNum);
            this.SetParamSimple(map, prefix + "Symbol", this.Symbol);
            this.SetParamSimple(map, prefix + "FirstIssueDate", this.FirstIssueDate);
            this.SetParamSimple(map, prefix + "CurrentIssueDate", this.CurrentIssueDate);
        }
    }
}

