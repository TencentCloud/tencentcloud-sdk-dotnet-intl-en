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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAigcApiTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>To update the Api Key</p>
        /// </summary>
        [JsonProperty("ApiToken")]
        public string ApiToken{ get; set; }

        /// <summary>
        /// <p><b>On-demand <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services after December 25, 2023, this field must be set to the app ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Merge (default, merge ExtInfo JSON by top-level key), Overwrite (direct overwrite)</p>
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// <p>The ip allowlist and model allowlist are stored in ExtInfo in json format, with the following fields:</p><p>(1) ip allowlist<br>&quot;ip&quot;: {&quot;127.0.0.1&quot;:true}<br>Not enabled: &quot;ip&quot;: {}<br>Multiple groups: {&quot;&#39;11.12.112.90&quot;:true,&quot;15.12.112.90&quot;:true}</p><p>(2) model allowlist<br>&quot;model&quot;: {&quot;deepseek-v4-pro&quot;:true}<br>Not enabled: &quot;model&quot;: {}</p><p>(3) name<br>&quot;name&quot;: &quot;test&quot;</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiToken", this.ApiToken);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

