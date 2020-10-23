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

namespace TencentCloud.Dms.V20200819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendEmailRequest : AbstractModel
    {
        
        /// <summary>
        /// Sender
        /// </summary>
        [JsonProperty("FromAddress")]
        public string FromAddress{ get; set; }

        /// <summary>
        /// Recipient
        /// </summary>
        [JsonProperty("ToAddress")]
        public string ToAddress{ get; set; }

        /// <summary>
        /// Email summary
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// Sender name
        /// </summary>
        [JsonProperty("FromName")]
        public string FromName{ get; set; }

        /// <summary>
        /// Reply-to address
        /// </summary>
        [JsonProperty("ReplyAddress")]
        public string ReplyAddress{ get; set; }

        /// <summary>
        /// The body of an HTML email
        /// </summary>
        [JsonProperty("HtmlContent")]
        public string HtmlContent{ get; set; }

        /// <summary>
        /// The body of a plain-text email
        /// </summary>
        [JsonProperty("TextContent")]
        public string TextContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FromAddress", this.FromAddress);
            this.SetParamSimple(map, prefix + "ToAddress", this.ToAddress);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamSimple(map, prefix + "FromName", this.FromName);
            this.SetParamSimple(map, prefix + "ReplyAddress", this.ReplyAddress);
            this.SetParamSimple(map, prefix + "HtmlContent", this.HtmlContent);
            this.SetParamSimple(map, prefix + "TextContent", this.TextContent);
        }
    }
}

