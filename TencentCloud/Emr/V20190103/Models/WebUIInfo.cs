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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebUIInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Access address, which may be left empty.</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>WebUI status. Valid values:<br>-1: indicates that the current service does not have WebUI;<br>0: indicates that the current service has WebUI but does not have the KNOX service installed;<br>1: indicates that the current service has WebUI and has the KNOX service installed, but it does not have public network access enabled for the KNOX service;<br>2: indicates that the current service has WebUI, has the KNOX service installed, and has public network access enabled.</p>
        /// </summary>
        [JsonProperty("WebUIStatus")]
        public long? WebUIStatus{ get; set; }

        /// <summary>
        /// <p>Service name.</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "WebUIStatus", this.WebUIStatus);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
        }
    }
}

