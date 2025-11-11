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

    public class DeleteRouteRequest : AbstractModel
    {
        
        /// <summary>
        /// ckafka cluster instance Id. obtain through the API [DescribeInstances](https://www.tencentcloud.comom/document/product/597/40835?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Route id, obtain through the API [DescribeRoute](https://www.tencentcloud.comom/document/product/597/45484?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("RouteId")]
        public long? RouteId{ get; set; }

        /// <summary>
        /// AppId of the caller.
        /// </summary>
        [JsonProperty("CallerAppid")]
        public long? CallerAppid{ get; set; }

        /// <summary>
        /// Sets the scheduled deletion time for routes. only public network routes support scheduled deletion. available for any time within the next 24 hours.
        /// </summary>
        [JsonProperty("DeleteRouteTime")]
        public string DeleteRouteTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RouteId", this.RouteId);
            this.SetParamSimple(map, prefix + "CallerAppid", this.CallerAppid);
            this.SetParamSimple(map, prefix + "DeleteRouteTime", this.DeleteRouteTime);
        }
    }
}

