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

    public class CheckAttributeLabelExistRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID.
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// Attribute name.
        /// </summary>
        [JsonProperty("LabelName")]
        public string LabelName{ get; set; }

        /// <summary>
        /// Attribute ID.
        /// </summary>
        [JsonProperty("AttributeBizId")]
        public string AttributeBizId{ get; set; }

        /// <summary>
        /// Log in to the user's root account (required in integrator mode).
        /// </summary>
        [JsonProperty("LoginUin")]
        public string LoginUin{ get; set; }

        /// <summary>
        /// Log in to the user's sub-account (required in integrator mode).
        /// </summary>
        [JsonProperty("LoginSubAccountUin")]
        public string LoginSubAccountUin{ get; set; }

        /// <summary>
        /// Scroll loading, the last attribute label ID.
        /// </summary>
        [JsonProperty("LastLabelBizId")]
        public string LastLabelBizId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "LabelName", this.LabelName);
            this.SetParamSimple(map, prefix + "AttributeBizId", this.AttributeBizId);
            this.SetParamSimple(map, prefix + "LoginUin", this.LoginUin);
            this.SetParamSimple(map, prefix + "LoginSubAccountUin", this.LoginSubAccountUin);
            this.SetParamSimple(map, prefix + "LastLabelBizId", this.LastLabelBizId);
        }
    }
}

