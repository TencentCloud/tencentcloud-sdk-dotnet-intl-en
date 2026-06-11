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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchDashboardSubscribeRequest : AbstractModel
    {
        
        /// <summary>
        /// Dashboard id. Obtain the DashboardId through the [Get Dashboard](https://www.tencentcloud.com/document/api/614/95636?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("DashboardId")]
        public string DashboardId{ get; set; }

        /// <summary>
        /// Dashboard subscription data.
        /// </summary>
        [JsonProperty("SubscribeData")]
        public DashboardSubscribeData SubscribeData{ get; set; }

        /// <summary>
        /// Dashboard subscription Id. Obtain through the api [Dashboard subscription list](https://www.tencentcloud.com/document/api/614/105779?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Dashboard subscription Name. Obtain through the api [Dashboard subscription list](https://www.tencentcloud.com/document/api/614/105779?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DashboardId", this.DashboardId);
            this.SetParamObj(map, prefix + "SubscribeData.", this.SubscribeData);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

