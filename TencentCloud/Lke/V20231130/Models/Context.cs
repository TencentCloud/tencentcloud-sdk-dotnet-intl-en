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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Context : AbstractModel
    {
        
        /// <summary>
        /// Message record ID.
        /// </summary>
        [JsonProperty("RecordBizId")]
        public string RecordBizId{ get; set; }

        /// <summary>
        /// Whether it is a user.
        /// </summary>
        [JsonProperty("IsVisitor")]
        public bool? IsVisitor{ get; set; }

        /// <summary>
        /// Nickname.
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// Avatar.
        /// </summary>
        [JsonProperty("Avatar")]
        public string Avatar{ get; set; }

        /// <summary>
        /// Message content.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// Document information.
        /// </summary>
        [JsonProperty("FileInfos")]
        public MsgFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// Response method, 15: clarification confirmation response.
        /// </summary>
        [JsonProperty("ReplyMethod")]
        public ulong? ReplyMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordBizId", this.RecordBizId);
            this.SetParamSimple(map, prefix + "IsVisitor", this.IsVisitor);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Avatar", this.Avatar);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamSimple(map, prefix + "ReplyMethod", this.ReplyMethod);
        }
    }
}

