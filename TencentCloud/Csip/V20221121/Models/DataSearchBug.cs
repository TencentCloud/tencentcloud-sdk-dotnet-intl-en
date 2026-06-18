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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataSearchBug : AbstractModel
    {
        
        /// <summary>
        /// Query status code
        /// </summary>
        [JsonProperty("StateCode")]
        public string StateCode{ get; set; }

        /// <summary>
        /// Vulnerability details
        /// </summary>
        [JsonProperty("DataBug")]
        public BugInfoDetail[] DataBug{ get; set; }

        /// <summary>
        /// Vulnerability impact assets details
        /// </summary>
        [JsonProperty("DataAsset")]
        public AssetInfoDetail[] DataAsset{ get; set; }

        /// <summary>
        /// True supports scanning. False does not support scanning.
        /// </summary>
        [JsonProperty("VSSScan")]
        public bool? VSSScan{ get; set; }

        /// <summary>
        /// 0-Not Supported; 1-Supported
        /// </summary>
        [JsonProperty("CWPScan")]
        public string CWPScan{ get; set; }

        /// <summary>
        /// 1 indicates virtual patches supported, 0 or null indicates not supported.
        /// </summary>
        [JsonProperty("CFWPatch")]
        public string CFWPatch{ get; set; }

        /// <summary>
        /// 0-Not Supported; 1-Supported
        /// </summary>
        [JsonProperty("WafPatch")]
        public long? WafPatch{ get; set; }

        /// <summary>
        /// 0-Not Supported; 1-Supported
        /// </summary>
        [JsonProperty("CWPFix")]
        public long? CWPFix{ get; set; }

        /// <summary>
        /// Product Support Status
        /// </summary>
        [JsonProperty("DataSupport")]
        public ProductSupport[] DataSupport{ get; set; }

        /// <summary>
        /// cveId
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StateCode", this.StateCode);
            this.SetParamArrayObj(map, prefix + "DataBug.", this.DataBug);
            this.SetParamArrayObj(map, prefix + "DataAsset.", this.DataAsset);
            this.SetParamSimple(map, prefix + "VSSScan", this.VSSScan);
            this.SetParamSimple(map, prefix + "CWPScan", this.CWPScan);
            this.SetParamSimple(map, prefix + "CFWPatch", this.CFWPatch);
            this.SetParamSimple(map, prefix + "WafPatch", this.WafPatch);
            this.SetParamSimple(map, prefix + "CWPFix", this.CWPFix);
            this.SetParamArrayObj(map, prefix + "DataSupport.", this.DataSupport);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
        }
    }
}

