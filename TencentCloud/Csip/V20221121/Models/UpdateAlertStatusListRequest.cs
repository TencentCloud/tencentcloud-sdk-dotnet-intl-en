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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAlertStatusListRequest : AbstractModel
    {
        
        /// <summary>
        /// Alarm ID list
        /// </summary>
        [JsonProperty("ID")]
        public NewAlertKey[] ID{ get; set; }

        /// <summary>
        /// Operation type. 
        /// 1: Revoke disposal 
        /// 2: Marked with processed 
        /// 3: Marked as ignored 
        /// 4: Cancel tag disposal
        /// 5: Unmark ignore
        /// </summary>
        [JsonProperty("OperateType")]
        public long? OperateType{ get; set; }

        /// <summary>
        /// Group Account Member ID
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// Member ID of the Called Group Account
        /// </summary>
        [JsonProperty("OperatedMemberId")]
        public string[] OperatedMemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ID.", this.ID);
            this.SetParamSimple(map, prefix + "OperateType", this.OperateType);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "OperatedMemberId.", this.OperatedMemberId);
        }
    }
}

