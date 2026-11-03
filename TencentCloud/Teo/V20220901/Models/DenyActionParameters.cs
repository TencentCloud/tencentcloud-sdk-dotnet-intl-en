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
        /// Whether to extend the block on the source IP. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>
        /// After enabled, the client IP that triggers the rule will be continuously blocked. When this option is enabled, the BlockIpDuration parameter must be specified simultaneously.
        /// Note: This option cannot intersect with ReturnCustomPage or Stall.
        /// </summary>
        [JsonProperty("BlockIp")]
        public string BlockIp{ get; set; }

        /// <summary>
        /// IP ban duration when BlockIP is on.
        /// </summary>
        [JsonProperty("BlockIpDuration")]
        public string BlockIpDuration{ get; set; }

        /// <summary>
        /// Whether to use custom pages. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>
        /// Enabled. Use custom page content to intercept (respond to) requests. When this option is enabled, you must specify the ResponseCode and ErrorPageId parameters simultaneously.
        /// Note: This option cannot intersect with BlockIp or Stall.
        /// </summary>
        [JsonProperty("ReturnCustomPage")]
        public string ReturnCustomPage{ get; set; }

        /// <summary>
        /// Status code of the custom page.
        /// </summary>
        [JsonProperty("ResponseCode")]
        public string ResponseCode{ get; set; }

        /// <summary>
        /// PageId of the custom page.
        /// </summary>
        [JsonProperty("ErrorPageId")]
        public string ErrorPageId{ get; set; }

        /// <summary>
        /// Whether to suspend requests from the request source without processing. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>
        /// Enabled. It no longer responds to requests in the current connection session and does not actively disconnect. When used for crawler counteraction, it consumes client connection resources.
        /// Note: This option cannot intersect with BlockIp or ReturnCustomPage.
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

