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

    public class CallBackInfo : AbstractModel
    {
        
        /// <summary>
        /// Callback Body.
        /// Place various alarm variables in the request content. For details, see the help documentation (https://www.tencentcloud.com/document/product/614/74718?from_cn_redirect=1).
        /// in the following example:
        /// 
        /// ```
        /// {
        /// "TopicId": "{{ .QueryLog[0][0].topicId }}",
        /// "key": "{{.Alarm}}",
        /// "time": "{{ .QueryLog[0][0].time }}",
        /// "log": "{{ .QueryLog[0][0].content.__CONTENT__ }}",
        /// "namespace": "{{ .QueryLog[0][0].content.__TAG__.namespace }}"
        /// }
        /// ```
        /// </summary>
        [JsonProperty("Body")]
        public string Body{ get; set; }

        /// <summary>
        /// HTTP request header field for callbacks.
        /// For example, the following request header field informs the server request content type is JSON.
        /// ```
        /// "Content-Type: application/json"
        /// ```
        /// </summary>
        [JsonProperty("Headers")]
        public string[] Headers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamArraySimple(map, prefix + "Headers.", this.Headers);
        }
    }
}

