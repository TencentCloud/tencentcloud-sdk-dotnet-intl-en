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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunMonitorServiceEnabled : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable [Tencent Cloud Observability Platform (formerly Cloud Monitor)](https://intl.cloud.tencent.com/document/product/248?from_cn_redirect=1) (TCOP). Valid values:
        /// <li>TRUE: enable TCOP.</li>
        /// <li>FALSE: disable TCOP.</li>
        /// Default value: TRUE.
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

