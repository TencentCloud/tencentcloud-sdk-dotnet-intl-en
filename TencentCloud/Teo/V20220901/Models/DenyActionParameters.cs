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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DenyActionParameters : AbstractModel
    {
        
        /// <summary>
        /// Specifies whether to extend the ban on the source IP. valid values.
        /// <li>`on`: Enable;</li>
        /// 
        /// <li>off: Disable.</li>
        /// 
        /// After enabled, continuously blocks client ips that trigger the rule. when this option is enabled, the BlockIpDuration parameter must be simultaneously designated.
        /// Note: this option cannot intersect with ReturnCustomPage or Stall.
        /// </summary>
        [JsonProperty("BlockIp")]
        public string BlockIp{ get; set; }

        /// <summary>
        /// The ban duration when BlockIP is on.
        /// </summary>
        [JsonProperty("BlockIpDuration")]
        public string BlockIpDuration{ get; set; }

        /// <summary>
        /// Specifies whether to use a custom page. valid values:.
        /// <li>`on`: Enable;</li>
        /// 
        /// <li>off: Disable.</li>
        /// 
        /// Enabled, use custom page content to intercept requests. when this option is enabled, ResponseCode and ErrorPageId parameters must be specified simultaneously.
        /// Note: this option cannot intersect with the BlockIp or Stall option.
        /// </summary>
        [JsonProperty("ReturnCustomPage")]
        public string ReturnCustomPage{ get; set; }

        /// <summary>
        /// Status code of the custom page.
        /// </summary>
        [JsonProperty("ResponseCode")]
        public string ResponseCode{ get; set; }

        /// <summary>
        /// Specifies the page id of the custom page.
        /// </summary>
        [JsonProperty("ErrorPageId")]
        public string ErrorPageId{ get; set; }

        /// <summary>
        /// Specifies whether to suspend the request source without processing. valid values:.
        /// <li>`on`: Enable;</li>
        /// 
        /// <li>off: Disable.</li>
        /// 
        /// Enabled, no longer responds to requests in the current connection session and does not actively disconnect. used for crawler combat to consume client connection resources.
        /// Note: this option cannot intersect with BlockIp or ReturnCustomPage options.
        /// </summary>
        [JsonProperty("Stall")]
        public string Stall{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlockIp", this.BlockIp);
            this.SetParamSimple(map, prefix + "BlockIpDuration", this.BlockIpDuration);
            this.SetParamSimple(map, prefix + "ReturnCustomPage", this.ReturnCustomPage);
            this.SetParamSimple(map, prefix + "ResponseCode", this.ResponseCode);
            this.SetParamSimple(map, prefix + "ErrorPageId", this.ErrorPageId);
            this.SetParamSimple(map, prefix + "Stall", this.Stall);
        }
    }
}

