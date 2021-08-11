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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeListListenerResponse : AbstractModel
    {
        
        /// <summary>
        /// List of layer-4 forwarding listeners
        /// </summary>
        [JsonProperty("Layer4Listeners")]
        public Layer4Rule[] Layer4Listeners{ get; set; }

        /// <summary>
        /// List of layer-7 forwarding listeners
        /// </summary>
        [JsonProperty("Layer7Listeners")]
        public Layer7Rule[] Layer7Listeners{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Layer4Listeners.", this.Layer4Listeners);
            this.SetParamArrayObj(map, prefix + "Layer7Listeners.", this.Layer7Listeners);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}
