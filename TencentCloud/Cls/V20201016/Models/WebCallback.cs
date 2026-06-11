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

    public class WebCallback : AbstractModel
    {
        
        /// <summary>
        /// Callback type. Valid values:
        /// -Http (custom webhook configuration)
        /// -WeCom
        /// -DingTalk
        /// -Lark
        /// </summary>
        [JsonProperty("CallbackType")]
        public string CallbackType{ get; set; }

        /// <summary>
        /// Callback URL, supports a maximum of 1024 bytes.
        /// You can also use WebCallbackId to refer to the URL in the integration configuration. At this point, please enter an empty string for this field.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Integration configuration ID. Obtain the integration configuration ID by searching the alarm channel callback configuration list (https://www.tencentcloud.com/document/product/614/115229?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("WebCallbackId")]
        public string WebCallbackId{ get; set; }

        /// <summary>
        /// Callback method. Valid values:
        /// -POST (default value)
        /// - PUT
        /// 
        /// Note:
        /// -Required when CallbackType is Http. No need to specify for other callback methods.
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// Notification content template ID. When Default-zh is used, DefaultTemplate (Chinese) is referenced. When Default-en is used, DefaultTemplate (English) is referenced.
        /// </summary>
        [JsonProperty("NoticeContentId")]
        public string NoticeContentId{ get; set; }

        /// <summary>
        /// Reminder type.
        /// 
        /// 0: No reminder; 1: Specified individual; 2: Everyone
        /// </summary>
        [JsonProperty("RemindType")]
        public ulong? RemindType{ get; set; }

        /// <summary>
        /// Mobile phone list.
        /// </summary>
        [JsonProperty("Mobiles")]
        public string[] Mobiles{ get; set; }

        /// <summary>
        /// User ID list.
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// This parameter is deprecated. Please use NoticeContentId.
        /// </summary>
        [JsonProperty("Headers")]
        [System.Obsolete]
        public string[] Headers{ get; set; }

        /// <summary>
        /// This parameter is deprecated. Please use NoticeContentId.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Body")]
        [System.Obsolete]
        public string Body{ get; set; }

        /// <summary>
        /// Serial number.
        /// -Invalid input parameter.
        /// -Output parameter is valid.
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallbackType", this.CallbackType);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "WebCallbackId", this.WebCallbackId);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "NoticeContentId", this.NoticeContentId);
            this.SetParamSimple(map, prefix + "RemindType", this.RemindType);
            this.SetParamArraySimple(map, prefix + "Mobiles.", this.Mobiles);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamArraySimple(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamSimple(map, prefix + "Index", this.Index);
        }
    }
}

