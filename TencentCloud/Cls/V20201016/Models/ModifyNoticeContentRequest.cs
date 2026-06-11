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

    public class ModifyNoticeContentRequest : AbstractModel
    {
        
        /// <summary>
        /// Notification content template ID. Obtain the notification content template ID by searching the notification content template (https://www.tencentcloud.com/document/api/614/111714?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("NoticeContentId")]
        public string NoticeContentId{ get; set; }

        /// <summary>
        /// Notification content template name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Content language of the notification.
        /// 
        /// 0-Chinese by default, 1-English
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Notification content template details.
        /// </summary>
        [JsonProperty("NoticeContents")]
        public NoticeContent[] NoticeContents{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NoticeContentId", this.NoticeContentId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "NoticeContents.", this.NoticeContents);
        }
    }
}

