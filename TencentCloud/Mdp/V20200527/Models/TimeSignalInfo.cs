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

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimeSignalInfo : AbstractModel
    {
        
        /// <summary>
        /// EventID.
        /// </summary>
        [JsonProperty("EventID")]
        public string EventID{ get; set; }

        /// <summary>
        /// UPIDType.
        /// </summary>
        [JsonProperty("UPIDType")]
        public string UPIDType{ get; set; }

        /// <summary>
        /// UPID.
        /// </summary>
        [JsonProperty("UPID")]
        public string UPID{ get; set; }

        /// <summary>
        /// TypeID.
        /// </summary>
        [JsonProperty("TypeID")]
        public string TypeID{ get; set; }

        /// <summary>
        /// Num.
        /// </summary>
        [JsonProperty("Num")]
        public string Num{ get; set; }

        /// <summary>
        /// Expected.
        /// </summary>
        [JsonProperty("Expected")]
        public string Expected{ get; set; }

        /// <summary>
        /// SubsegmentNum.
        /// </summary>
        [JsonProperty("SubsegmentNum")]
        public string SubsegmentNum{ get; set; }

        /// <summary>
        /// SubsegmentsExpected.
        /// </summary>
        [JsonProperty("SubsegmentsExpected")]
        public string SubsegmentsExpected{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventID", this.EventID);
            this.SetParamSimple(map, prefix + "UPIDType", this.UPIDType);
            this.SetParamSimple(map, prefix + "UPID", this.UPID);
            this.SetParamSimple(map, prefix + "TypeID", this.TypeID);
            this.SetParamSimple(map, prefix + "Num", this.Num);
            this.SetParamSimple(map, prefix + "Expected", this.Expected);
            this.SetParamSimple(map, prefix + "SubsegmentNum", this.SubsegmentNum);
            this.SetParamSimple(map, prefix + "SubsegmentsExpected", this.SubsegmentsExpected);
        }
    }
}

