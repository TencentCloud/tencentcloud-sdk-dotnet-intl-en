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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRouteRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ckafka cluster instance Id</p><p>For reference: <a href="https://www.tencentcloud.com/document/api/597/40835?from_cn_redirect=1">DescribeInstances</a></p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Route Id</p>
        /// </summary>
        [JsonProperty("RouteId")]
        public long? RouteId{ get; set; }

        /// <summary>
        /// <p>Whether to display the primary route. If true, the primary route information during instance creation will additionally be displayed on the basis of the original routing list (and will not be affected by parameter filtering such as InternalFlag or UsedFor).</p>
        /// </summary>
        [JsonProperty("MainRouteFlag")]
        public bool? MainRouteFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RouteId", this.RouteId);
            this.SetParamSimple(map, prefix + "MainRouteFlag", this.MainRouteFlag);
        }
    }
}

