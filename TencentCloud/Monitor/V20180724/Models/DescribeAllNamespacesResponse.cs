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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAllNamespacesResponse : AbstractModel
    {
        
        /// <summary>
        /// Alarm policy type of Tencent Cloud service (disused)
        /// </summary>
        [JsonProperty("QceNamespaces")]
        public CommonNamespace QceNamespaces{ get; set; }

        /// <summary>
        /// Other alarm policy type (disused)
        /// </summary>
        [JsonProperty("CustomNamespaces")]
        public CommonNamespace CustomNamespaces{ get; set; }

        /// <summary>
        /// Alarm policy type of Tencent Cloud service
        /// </summary>
        [JsonProperty("QceNamespacesNew")]
        public CommonNamespace[] QceNamespacesNew{ get; set; }

        /// <summary>
        /// Other alarm policy type (not supported currently)
        /// </summary>
        [JsonProperty("CustomNamespacesNew")]
        public CommonNamespace[] CustomNamespacesNew{ get; set; }

        /// <summary>
        /// General alarm policy type, including TAPM, RUM, and CAT.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CommonNamespaces")]
        public CommonNamespaceNew[] CommonNamespaces{ get; set; }

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
            this.SetParamObj(map, prefix + "QceNamespaces.", this.QceNamespaces);
            this.SetParamObj(map, prefix + "CustomNamespaces.", this.CustomNamespaces);
            this.SetParamArrayObj(map, prefix + "QceNamespacesNew.", this.QceNamespacesNew);
            this.SetParamArrayObj(map, prefix + "CustomNamespacesNew.", this.CustomNamespacesNew);
            this.SetParamArrayObj(map, prefix + "CommonNamespaces.", this.CommonNamespaces);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

