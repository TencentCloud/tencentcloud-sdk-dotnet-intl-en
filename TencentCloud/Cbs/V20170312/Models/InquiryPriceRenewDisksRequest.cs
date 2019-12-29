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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryPriceRenewDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the cloud disk, which can be queried via the API [DescribeDisks](/document/product/362/16315).
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// Relevant parameter settings for the prepaid mode (i.e., monthly subscription). The monthly subscription cloud disk purchase usage period can be specified using this parameter. If this parameter is specified as CurInstanceDeadline, then it will be renewed according to the aligned CVM expiration time. If it is a batch renewal price query, then this parameter will correspond to the Disks parameter, and the element quantity needs to be kept the same.
        /// </summary>
        [JsonProperty("DiskChargePrepaids")]
        public DiskChargePrepaid[] DiskChargePrepaids{ get; set; }

        /// <summary>
        /// Specify the new expiration time of the cloud disk, in such format as 2017-12-17 00:00:00. The parameters `NewDeadline` and `DiskChargePrepaids` are two options to specify the inquiry length, and you must specify at least one.
        /// </summary>
        [JsonProperty("NewDeadline")]
        public string NewDeadline{ get; set; }

        /// <summary>
        /// ID of project the cloud disk belongs to. If selected, it can only be used for authentication.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamArrayObj(map, prefix + "DiskChargePrepaids.", this.DiskChargePrepaids);
            this.SetParamSimple(map, prefix + "NewDeadline", this.NewDeadline);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
        }
    }
}

