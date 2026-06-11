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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRiskDnsEventStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// Array of malicious request event IDs. It is required for adding to the allowlist. Otherwise, choose Filters or EventIDSet.
        /// </summary>
        [JsonProperty("EventIDSet")]
        public ulong?[] EventIDSet{ get; set; }

        /// <summary>
        /// Mark the status of the event.
        /// EVENT_UNDEAL: Unprocessed (unignore)
        /// EVENT_DEALED: Processed
        /// EVENT_IGNORE: Ignore
        /// EVENT_DELETE: Deleted
        /// EVENT_ADD_WHITE: Add to whitelist
        /// EVENT_ISOLATE_CONTAINER: Isolate container
        /// EVENT_RESTORE_CONTAINER: Restore CONTAINER.
        /// </summary>
        [JsonProperty("EventStatus")]
        public string EventStatus{ get; set; }

        /// <summary>
        /// Allowlist Domain/IP
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Adding Identical Request Domain Name/IP Events to Allowlist
        /// </summary>
        [JsonProperty("AllSameEventAddWhite")]
        public bool? AllSameEventAddWhite{ get; set; }

        /// <summary>
        /// Allowlist Adding Event Type. DOMAIN: Malicious Domain Request; IP: Malicious IP Request
        /// </summary>
        [JsonProperty("AddWhiteEventType")]
        public string AddWhiteEventType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "EventIDSet.", this.EventIDSet);
            this.SetParamSimple(map, prefix + "EventStatus", this.EventStatus);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AllSameEventAddWhite", this.AllSameEventAddWhite);
            this.SetParamSimple(map, prefix + "AddWhiteEventType", this.AddWhiteEventType);
        }
    }
}

