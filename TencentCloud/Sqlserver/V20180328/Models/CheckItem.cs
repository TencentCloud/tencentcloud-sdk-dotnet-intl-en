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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckItem : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CheckName")]
        public string CheckName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Passed")]
        public long? Passed{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IsAffect")]
        public long? IsAffect{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Msg")]
        public string Msg{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MsgCode")]
        public long? MsgCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckName", this.CheckName);
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "Passed", this.Passed);
            this.SetParamSimple(map, prefix + "IsAffect", this.IsAffect);
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamSimple(map, prefix + "MsgCode", this.MsgCode);
        }
    }
}

