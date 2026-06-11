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

    public class ModifyWebCallbackRequest : AbstractModel
    {
        
        /// <summary>
        /// Alarm channel callback configuration ID. Obtain the alarm channel callback configuration ID by searching the alarm channel callback configuration list (https://www.tencentcloud.com/document/api/614/115229?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("WebCallbackId")]
        public string WebCallbackId{ get; set; }

        /// <summary>
        /// Alarm channel callback configuration name. Supports a maximum of 255 bytes.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Channel type
        /// 
        /// WeCom: WeCom; DingTalk: DingTalk; Lark: Lark; Http: Custom Callback;
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Callback URL.
        /// </summary>
        [JsonProperty("Webhook")]
        public string Webhook{ get; set; }

        /// <summary>
        /// Request method.
        /// 
        /// Support POST, PUT.
        /// 
        /// Note: This parameter is required when Type is set to Http.
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// Secret key information. Supports a maximum of 1024 bytes.
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WebCallbackId", this.WebCallbackId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Webhook", this.Webhook);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Key", this.Key);
        }
    }
}

