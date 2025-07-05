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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Filter : AbstractModel
    {
        
        /// <summary>
        /// Equals: 0, not equals: 1.
        /// </summary>
        [JsonProperty("Operator")]
        public long? Operator{ get; set; }

        /// <summary>
        /// Tag name, optional values include:
        /// 1. method, request method name;
        /// 2. proto: protocol name;
        /// 3. service: service name;
        /// 4. status: response status code;
        /// 5.result: response details
        /// 6.check: check name.
        /// </summary>
        [JsonProperty("LabelName")]
        public string LabelName{ get; set; }

        /// <summary>
        /// Tag value, optional values include:
        /// 1.method: request method name, for example, GET, POST, PUT, etc.
        /// 2.proto: protocol name, for example, HTTP/1.1, HTTP/2, etc.
        /// 3.service: service name, for example, the request URL such as http://httpbin.org/get
        /// 4.status: response status code, for example, 200, 404, 500, etc.
        /// 5.result: response details, used to determine whether the request was successful or failed; if successful, the result Tag value is ok; if failed, the result Tag carries an error code and description.
        /// 6.check: check name, the Tag value is the checkpoint name set by the user.
        /// </summary>
        [JsonProperty("LabelValue")]
        public string LabelValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "LabelName", this.LabelName);
            this.SetParamSimple(map, prefix + "LabelValue", this.LabelValue);
        }
    }
}

