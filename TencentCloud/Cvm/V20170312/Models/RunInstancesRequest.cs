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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance [billing type](https://intl.cloud.tencent.com/document/product/213/2180?from_cn_redirect=1). <br><li>`PREPAID`: Monthly Subscription, used for at least one month <br><li>`POSTPAID_BY_HOUR`: Hourly-based pay-as-you-go <br><li>`CDHPAID`: [Dedicated CVM](https://www.tencentcloud.com/document/product/416/5068?lang=en&pg=) (associated with a dedicated host. Resource usage of the dedicated host is free of charge.) <br><li>`SPOTPAID`: [Spot instance](https://intl.cloud.tencent.com/document/product/213/17817)<br>Default value: `POSTPAID_BY_HOUR`.
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// Details of the monthly subscription, including the purchase period, auto-renewal. It is required if the `InstanceChargeType` is `PREPAID`.
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// Location of the instance. You can use this parameter to specify the availability zone, project, and CDH (for dedicated CVMs).
        ///  <b>Note: `Placement` is required when `LaunchTemplate` is not specified. If both the parameters are passed in, `Placement` prevails.</b>
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// The instance model. 
        /// <br><li>To view specific values for `POSTPAID_BY_HOUR` instances, you can call [DescribeInstanceTypeConfigs](https://intl.cloud.tencent.com/document/api/213/15749?from_cn_redirect=1) or refer to [Instance Types](https://intl.cloud.tencent.com/document/product/213/11518?from_cn_redirect=1). <br><li>For `CDHPAID` instances, the value of this parameter is in the format of `CDH_XCXG` based on the number of CPU cores and memory capacity. For example, if you want to create a CDH instance with a single-core CPU and 1 GB memory, specify this parameter as `CDH_1C1G`.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// The [image](https://intl.cloud.tencent.com/document/product/213/4940?from_cn_redirect=1) ID in the format of `img-xxx`. There are three types of images:<br/><li>Public images</li><li>Custom images</li><li>Shared images</li><br/>To check the image ID:<br/><li>For public images, custom images, and shared images, go to the [CVM console](https://console.cloud.tencent.com/cvm/image?rid=1&imageType=PUBLIC_IMAGE). </li><li>Call [DescribeImages](https://intl.cloud.tencent.com/document/api/213/15715?from_cn_redirect=1), pass in `InstanceType` to retrieve the list of images supported by the current model, and then find the `ImageId` in the response.</li>
        ///  <b>Note: `ImageId` is required when `LaunchTemplate` is not specified. If both the parameters are passed in, `ImageId` prevails.</b>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// System disk configuration of the instance. If this parameter is not specified, the default value will be used.
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// The configuration information of instance data disks. If this parameter is not specified, no data disk will be purchased by default. When purchasing, you can specify 21 data disks, which can contain at most 1 LOCAL_BASIC or LOCAL_SSD data disk, and at most 20 CLOUD_BASIC, CLOUD_PREMIUM, or CLOUD_SSD data disks.
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// Configuration information of VPC. This parameter is used to specify VPC ID and subnet ID, etc. If a VPC IP is specified in this parameter, it indicates the primary ENI IP of each instance. The value of parameter InstanceCount must be the same as the number of VPC IPs, which cannot be greater than 20.
        /// </summary>
        [JsonProperty("VirtualPrivateCloud")]
        public VirtualPrivateCloud VirtualPrivateCloud{ get; set; }

        /// <summary>
        /// Configuration of public network bandwidth. If this parameter is not specified, 0 Mbps will be used by default.
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// The number of instances to be purchased. Value range for pay-as-you-go instances: [1, 100]. Default value: `1`. The specified number of instances to be purchased cannot exceed the remaining quota allowed for the user. For more information on the quota, see [Quota for CVM Instances](https://intl.cloud.tencent.com/document/product/213/2664).
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// Specifies the minimum number of instances to create. value range: positive integer not greater than InstanceCount.
        /// Specifies the minimum purchasable quantity, guarantees to create at least MinCount instances, and creates InstanceCount instances as much as possible.
        /// Insufficient inventory to meet the minimum purchasable quantity will trigger an error info indicating insufficient stock.
        /// Only applicable to accounts, regions, and billing modes (annual/monthly subscription, pay-as-you-go, spot instance, exclusive sales) with partial support.
        /// </summary>
        [JsonProperty("MinCount")]
        public long? MinCount{ get; set; }

        /// <summary>
        /// Instance display name.<br><li>If no instance display name is specified, it will display 'unnamed' by default.</li><li>Supports up to 128 characters (including pattern strings).</li><li>When purchasing multiple instances:.
        /// - Specify a pattern string {R:x}: Generates a numeric sequence [x, x+n-1], where n represents the number of purchased instances. For example: Input server_{R:3}. When purchasing 1 instance, the display name is server_3; when purchasing 2 instances, the display names are server_3 and server_4.
        /// - Specify a pattern string {R:x,F:y}: y indicates fixed digit (optional), value range [0,8], default value 0 means no fixed digit (equivalent to {R:x}). Automatically pads with zeros when digits are insufficient, for example: input server_{R:3,F:3}, when purchasing 2 instances, the instance display name is server_003, server_004. If digit count exceeds y (such as {R:99,F:2}), the actual number is used, for example: app_{R:99,F:2}, when purchasing 2 instances, the instance display name is app_99, app_100.
        /// - Pattern strings must strictly follow the format {R:x,F:y} or {R:x}. Invalid formats (such as {}) are treated as plain text. Multiple pattern strings are supported.
        /// - No pattern string specified: The display name is appended with suffix 1, 2...n, where n indicates the number of instances purchased. For example server_. When purchasing 2 instances, generates server_1 and server_2.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance login settings. You can use this parameter to set the login method, password and key of the instance, or keep the original login settings of the image. If it's not specified, the user needs to set the login password using the "Reset password" option in the CVM console or calling the API `ResetInstancesPassword` to complete the creation of the CVM instance(s).
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// Security group to which an instance belongs. obtain this parameter by calling the `SecurityGroupId` field in the return value of [DescribeSecurityGroups](https://www.tencentcloud.com/document/product/215/15808?from_search=1). if not specified, bind the default security group under the designated project. if the default security group does not exist, automatically create it.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Enhanced service. You can use this parameter to specify whether to enable services such as Anti-DDoS and Cloud Monitor. If this parameter is not specified, Cloud Monitor and Anti-DDoS are enabled for public images by default. However, for custom images and images from the marketplace, Anti-DDoS and Cloud Monitor are not enabled by default. The original services in the image will be retained.
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// A unique string supplied by the client to ensure that the request is idempotent. Its maximum length is 64 ASCII characters. If this parameter is not specified, the idem-potency of the request cannot be guaranteed.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// Instance HostName.<br><li>Period (.) and hyphen (-) should not be used as the first or last character of the hostname, and should not be used consecutively.</li><br><li>Windows instances: The hostname should contain 2 to 15 characters, including letters (case insensitive), digits, and hyphens (-), does not support periods (.), and should not be all digits.</li><br><li>Instances of other types (such as Linux instances): The hostname should contain 2 to 60 characters, including multiple periods (.), with each segment between periods considered as one section. Each section can contain letters (case insensitive), digits, and hyphens (-).</li><br><li>When purchasing multiple instances:
        /// - Specify a pattern string {R:x}: Generates a numeric sequence [x, x+n-1], where n represents the number of purchased instances. For example: Input server_{R:3}. When purchasing 1 instance, the hostname is server_3; when purchasing 2 instances, the hostnames are server_3 and server_4.
        /// - Specify a pattern string {R:x,F:y}: y indicates fixed digit width (optional), valid range [0,8]. Default value 0 means no fixed width (equivalent to {R:x}). Insufficient digits are automatically padded with zeros. For example: Input server{R:3,F:3}. When purchasing 2 instances, the hostnames are server_003 and server_004. If the number of digits exceeds y (e.g., {R:99,F:2}), the actual digit count is used. For example: app{R:99,F:2}. When purchasing 2 instances, the hostnames are app_99 and app_100.
        /// - Specify a pattern string {IP}: Automatically replace with the private IP address of the instance. For example: input node-{IP}, the instance hostname is node-10.0.12.8. Supports mixed use with serial number pattern strings, such as: input web-{IP}-{R:1}, when purchasing 2 instances, the instance hostnames are web-10.0.12.8-1 and web-10.0.12.9-2 respectively.
        /// - Pattern strings must strictly follow the format {R:x,F:y}, {R:x}, or {IP}. Invalid formats (such as {}) are treated as plain text. Multiple pattern strings are supported.
        /// - No specified pattern string: add suffix 1, 2...n to instance hostname, where n means the number of purchased instances, such as server_1, server_2 when purchasing 2 instances.
        /// </li>
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Scheduled tasks. You can use this parameter to specify scheduled tasks for the instance. Only scheduled termination is supported.
        /// </summary>
        [JsonProperty("ActionTimer")]
        public ActionTimer ActionTimer{ get; set; }

        /// <summary>
        /// Placement group ID. You can only specify one.
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// List of tag description. By specifying this parameter, the tag can be bound to the corresponding CVM and CBS instances at the same time.
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification[] TagSpecification{ get; set; }

        /// <summary>
        /// The market options of the instance.
        /// </summary>
        [JsonProperty("InstanceMarketOptions")]
        public InstanceMarketOptionsRequest InstanceMarketOptions{ get; set; }

        /// <summary>
        /// User data provided to the instance. This parameter needs to be encoded in base64 format with the maximum size of 16 KB. For more information on how to get the value of this parameter, see the commands you need to execute on startup for [Windows](https://intl.cloud.tencent.com/document/product/213/17526) or [Linux](https://intl.cloud.tencent.com/document/product/213/17525).
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// Custom metadata. specifies the support for creating custom metadata key-value pairs when creating a CVM.
        /// **Note: this field is in beta test.**.
        /// </summary>
        [JsonProperty("Metadata")]
        public Metadata Metadata{ get; set; }

        /// <summary>
        /// Whether the request is a dry run only.
        /// `true`: dry run only. The request will not create instance(s). A dry run can check whether all the required parameters are specified, whether the request format is right, whether the request exceeds service limits, and whether the specified CVMs are available.
        /// If the dry run fails, the corresponding error code will be returned.
        /// If the dry run succeeds, the RequestId will be returned.
        /// `false` (default value): Send a normal request and create instance(s) if all the requirements are met.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// Information about the CPU topology of an instance. If not specified, it is determined by system resources.
        /// </summary>
        [JsonProperty("CpuTopology")]
        public CpuTopology CpuTopology{ get; set; }

        /// <summary>
        /// CAM role name, which can be obtained from the `roleName` field in the response of the [`DescribeRoleList`](https://intl.cloud.tencent.com/document/product/598/36223?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("CamRoleName")]
        public string CamRoleName{ get; set; }

        /// <summary>
        /// HPC cluster ID. The HPC cluster must and can only be specified for a high-performance computing instance.
        /// </summary>
        [JsonProperty("HpcClusterId")]
        public string HpcClusterId{ get; set; }

        /// <summary>
        /// Instance launch template.
        /// </summary>
        [JsonProperty("LaunchTemplate")]
        public LaunchTemplate LaunchTemplate{ get; set; }

        /// <summary>
        /// Specify the ID of the dedicated cluster where the CVM is created.
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// Specify the CHC physical server that used to create the CHC CVM.
        /// </summary>
        [JsonProperty("ChcIds")]
        public string[] ChcIds{ get; set; }

        /// <summary>
        /// Instance termination protection flag, indicating whether an instance is allowed to be deleted through an API. Valid values:<br><li>true: Instance protection is enabled, and the instance is not allowed to be deleted through the API.</li><br><li>false: Instance protection is disabled, and the instance is allowed to be deleted through the API.</li><br><br>Default value: false.
        /// </summary>
        [JsonProperty("DisableApiTermination")]
        public bool? DisableApiTermination{ get; set; }

        /// <summary>
        /// Whether the instance enables jumbo frames. valid values:<br><li/> true: means the instance enables jumbo frames. only models supporting jumbo frames can be set to true.<br><li/> false: means the instance disables jumbo frames. only models supporting jumbo frames can be set to false.<br> instance specifications supporting jumbo frames: [instance specifications](https://www.tencentcloud.com/document/product/213/11518?lang=en&pg=).
        /// </summary>
        [JsonProperty("EnableJumboFrame")]
        public bool? EnableJumboFrame{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamObj(map, prefix + "VirtualPrivateCloud.", this.VirtualPrivateCloud);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "MinCount", this.MinCount);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamObj(map, prefix + "ActionTimer.", this.ActionTimer);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamObj(map, prefix + "InstanceMarketOptions.", this.InstanceMarketOptions);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamObj(map, prefix + "CpuTopology.", this.CpuTopology);
            this.SetParamSimple(map, prefix + "CamRoleName", this.CamRoleName);
            this.SetParamSimple(map, prefix + "HpcClusterId", this.HpcClusterId);
            this.SetParamObj(map, prefix + "LaunchTemplate.", this.LaunchTemplate);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamArraySimple(map, prefix + "ChcIds.", this.ChcIds);
            this.SetParamSimple(map, prefix + "DisableApiTermination", this.DisableApiTermination);
            this.SetParamSimple(map, prefix + "EnableJumboFrame", this.EnableJumboFrame);
        }
    }
}

