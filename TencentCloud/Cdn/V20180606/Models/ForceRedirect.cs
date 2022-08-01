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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ForceRedirect : AbstractModel
    {
        
        /// <summary>
        /// Access forced redirect configuration switch
        /// `on`: Enable
        /// `off`: Disable
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Access forced redirect types
        /// http: forced HTTP redirect
        /// https: forced HTTPS redirect
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RedirectType")]
        public string RedirectType{ get; set; }

        /// <summary>
        /// Status code returned for forced redirect 
        /// Supports 301, 302.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RedirectStatusCode")]
        public long? RedirectStatusCode{ get; set; }

        /// <summary>
        /// Whether to return the newly added header during force redirection
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CarryHeaders")]
        public string CarryHeaders{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "RedirectType", this.RedirectType);
            this.SetParamSimple(map, prefix + "RedirectStatusCode", this.RedirectStatusCode);
            this.SetParamSimple(map, prefix + "CarryHeaders", this.CarryHeaders);
        }
    }
}

