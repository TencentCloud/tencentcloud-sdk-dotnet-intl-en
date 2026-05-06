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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LaneTrafficEntry : AbstractModel
    {
        
        /// <summary>
        /// // If type == "polarismesh.cn/gateway/tse-gateway", the selector is TSEGatewaySelector.
        /// // type == "polarismesh.cn/gateway/spring-cloud-gateway", selector is ServiceGatewaySelector
        /// // If type == "polarismesh.cn/service", selector is ServiceSelector
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EntryType")]
        public string EntryType{ get; set; }

        /// <summary>
        /// TSE cloud-native gateway selector
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TSEGatewaySelector")]
        public TSEGatewaySelector TSEGatewaySelector{ get; set; }

        /// <summary>
        /// Microservice gateway selector
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceGatewaySelector")]
        public ServiceGatewaySelector ServiceGatewaySelector{ get; set; }

        /// <summary>
        /// Standard microservice selector
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceSelector")]
        public ServiceSelector ServiceSelector{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EntryType", this.EntryType);
            this.SetParamObj(map, prefix + "TSEGatewaySelector.", this.TSEGatewaySelector);
            this.SetParamObj(map, prefix + "ServiceGatewaySelector.", this.ServiceGatewaySelector);
            this.SetParamObj(map, prefix + "ServiceSelector.", this.ServiceSelector);
        }
    }
}

