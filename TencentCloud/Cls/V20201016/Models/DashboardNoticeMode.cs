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

    public class DashboardNoticeMode : AbstractModel
    {
        
        /// <summary>
        /// Dashboard notification method.
        /// 
        /// -Uin: Tencent Cloud user
        /// -Group: Tencent Cloud user group
        /// -WeCom: wecom callback
        /// -Email: Custom email
        /// -DingTalk
        /// -Lark
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// Value of the known method.
        /// -When ReceiverType is `WeCom`, `DingTalk`, or `Lark`, Values must be empty and the Url field is required.
        /// -When ReceiverType is `Uin`, `Group`, or `Email`, the Values field is required and the Url field must be empty.
        /// -When ReceiverType is `Uin`, Values is the user id. Obtain the sub-user UID by [querying sub-users](https://www.tencentcloud.com/document/product/598/34587?from_cn_redirect=1).
        /// -When ReceiverType is `Group`, Values is the user Group id. Obtain user Group id by querying the user Group list (https://www.tencentcloud.com/document/product/598/34589?from_cn_redirect=1).
        /// -When ReceiverType is `Email`, Values is the user email info.
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// Dashboard notification channel.
        /// 
        /// -Support: ["Email","Sms","WeChat","Phone"].
        /// -When ReceiverType is `Email` or `WeCom`, ReceiverChannels is invalid.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReceiverChannels")]
        public string[] ReceiverChannels{ get; set; }

        /// <summary>
        /// Subscription method - Callback URL.
        /// -When ReceiverType is `WeCom`, `DingTalk`, or `Lark`, the Url field is required as the callback URL of each channel.
        /// -When the value is `WeCom`, the Url is the enterprise wechat callback address.
        /// -When the value is `DingTalk`, Url is the chatbot Webhook address.
        /// -When `Lark`, Url is the chatbot Webhook address.
        /// -When ReceiverType is `Uin`, `Group`, or `Email`, the Url field must be empty.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamArraySimple(map, prefix + "ReceiverChannels.", this.ReceiverChannels);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

