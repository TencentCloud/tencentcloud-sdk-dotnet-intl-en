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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessURLRedirectParameters : AbstractModel
    {
        
        /// <summary>
        /// Status code. valid values: 301, 302, 303, 307, 308.
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// Target request protocol. valid values:.
        /// <Li>Http: target request protocol http;</li>.
        /// <Li>Https: target request protocol https;</li>.
        /// <Li>Follow: follow the request.</li>.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Target hostname.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("HostName")]
        public HostName HostName{ get; set; }

        /// <summary>
        /// Target path.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("URLPath")]
        public URLPath URLPath{ get; set; }

        /// <summary>
        /// Carry query parameters.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("QueryString")]
        public AccessURLRedirectQueryString QueryString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "HostName.", this.HostName);
            this.SetParamObj(map, prefix + "URLPath.", this.URLPath);
            this.SetParamObj(map, prefix + "QueryString.", this.QueryString);
        }
    }
}

