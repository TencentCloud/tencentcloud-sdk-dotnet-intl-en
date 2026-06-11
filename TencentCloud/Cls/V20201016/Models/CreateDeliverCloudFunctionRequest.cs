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

    public class CreateDeliverCloudFunctionRequest : AbstractModel
    {
        
        /// <summary>
        /// TopicId to which the Shipping Rule belongs.
        /// -Obtain the log topic Id through [Get Log Topic List](https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1).
        /// -Obtain the log topic Id through [Create Log Topic](https://www.tencentcloud.com/document/product/614/56456?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Name of the cloud function for delivery. Only event functions (https://www.tencentcloud.com/document/product/583/9694?from_cn_redirect=1#scf-.E4.BA.8B.E4.BB.B6.E5.87.BD.E6.95.B0) (function type selection (https://www.tencentcloud.com/document/product/583/73483?from_cn_redirect=1)) are supported.
        /// Get function information by [getting the function list](https://www.tencentcloud.com/document/product/583/18582?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Namespace. See [Namespace management](https://www.tencentcloud.com/document/product/583/35913?from_cn_redirect=1).
        /// -Obtain the Name by listing the namespace list (https://www.tencentcloud.com/document/product/583/37158?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Function version.
        /// -Get the function version by [querying the function version](https://www.tencentcloud.com/document/product/583/37162?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// Maximum waiting time for delivery. Unit: seconds. Default: 60.
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// Maximum number of messages to deliver. Default is 100. Supported range [1,10000].
        /// </summary>
        [JsonProperty("MaxMsgNum")]
        public ulong? MaxMsgNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "MaxMsgNum", this.MaxMsgNum);
        }
    }
}

