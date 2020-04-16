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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainErrorPageInfo : AbstractModel
    {
        
        /// <summary>
        /// Configuration ID of a custom error response
        /// </summary>
        [JsonProperty("ErrorPageId")]
        public string ErrorPageId{ get; set; }

        /// <summary>
        /// Listener ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Original error code
        /// </summary>
        [JsonProperty("ErrorNos")]
        public long?[] ErrorNos{ get; set; }

        /// <summary>
        /// New error code
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NewErrorNo")]
        public long? NewErrorNo{ get; set; }

        /// <summary>
        /// Response header to be cleared
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClearHeaders")]
        public string[] ClearHeaders{ get; set; }

        /// <summary>
        /// Response header to be set
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SetHeaders")]
        public HttpHeaderParam[] SetHeaders{ get; set; }

        /// <summary>
        /// Configured response body (excluding HTTP header)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Body")]
        public string Body{ get; set; }

        /// <summary>
        /// Rule status. 0: success
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrorPageId", this.ErrorPageId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "ErrorNos.", this.ErrorNos);
            this.SetParamSimple(map, prefix + "NewErrorNo", this.NewErrorNo);
            this.SetParamArraySimple(map, prefix + "ClearHeaders.", this.ClearHeaders);
            this.SetParamArrayObj(map, prefix + "SetHeaders.", this.SetHeaders);
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

