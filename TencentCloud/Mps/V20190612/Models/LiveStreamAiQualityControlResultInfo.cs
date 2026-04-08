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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveStreamAiQualityControlResultInfo : AbstractModel
    {
        
        /// <summary>
        /// Content quality inspection result list.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QualityControlResults")]
        [System.Obsolete]
        public QualityControlResult[] QualityControlResults{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DiagnoseResults")]
        [System.Obsolete]
        public DiagnoseResult[] DiagnoseResults{ get; set; }

        /// <summary>
        /// Content quality inspection result list.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QualityControlResultSet")]
        public QualityControlResult[] QualityControlResultSet{ get; set; }

        /// <summary>
        /// Format diagnostic result list.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiagnoseResultSet")]
        public DiagnoseResult[] DiagnoseResultSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "QualityControlResults.", this.QualityControlResults);
            this.SetParamArrayObj(map, prefix + "DiagnoseResults.", this.DiagnoseResults);
            this.SetParamArrayObj(map, prefix + "QualityControlResultSet.", this.QualityControlResultSet);
            this.SetParamArrayObj(map, prefix + "DiagnoseResultSet.", this.DiagnoseResultSet);
        }
    }
}

