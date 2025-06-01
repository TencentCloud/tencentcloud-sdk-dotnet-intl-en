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

namespace TencentCloud.Cvm.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cvm.V20170312.Models;

   public class CvmClient : AbstractClient{

       private const string endpoint = "cvm.intl.tencentcloudapi.com";
       private const string version = "2017-03-12";
       private const string sdkVersion = "SDK_NET_3.0.1142";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CvmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CvmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create CDH instances with specified configuration.
        /// * When HostChargeType is PREPAID, the HostChargePrepaid parameter must be specified.
        /// </summary>
        /// <param name="req"><see cref="AllocateHostsRequest"/></param>
        /// <returns><see cref="AllocateHostsResponse"/></returns>
        public Task<AllocateHostsResponse> AllocateHosts(AllocateHostsRequest req)
        {
            return InternalRequestAsync<AllocateHostsResponse>(req, "AllocateHosts");
        }

        /// <summary>
        /// This API is used to create CDH instances with specified configuration.
        /// * When HostChargeType is PREPAID, the HostChargePrepaid parameter must be specified.
        /// </summary>
        /// <param name="req"><see cref="AllocateHostsRequest"/></param>
        /// <returns><see cref="AllocateHostsResponse"/></returns>
        public AllocateHostsResponse AllocateHostsSync(AllocateHostsRequest req)
        {
            return InternalRequestAsync<AllocateHostsResponse>(req, "AllocateHosts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to associate key pairs with instances.
        /// 
        /// * If the public key of a key pair is written to the `SSH` configuration of the instance, users will be able to log in to the instance with the private key of the key pair.
        /// * If the instance is already associated with a key, the old key will become invalid.
        /// If you currently use a password to log in, you will no longer be able to do so after you associate the instance with a key.
        /// * Batch operations are supported. The maximum number of instances in each request is 100. If any instance in the request cannot be associated with a key, you will get an error code.
        /// </summary>
        /// <param name="req"><see cref="AssociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="AssociateInstancesKeyPairsResponse"/></returns>
        public Task<AssociateInstancesKeyPairsResponse> AssociateInstancesKeyPairs(AssociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<AssociateInstancesKeyPairsResponse>(req, "AssociateInstancesKeyPairs");
        }

        /// <summary>
        /// This API is used to associate key pairs with instances.
        /// 
        /// * If the public key of a key pair is written to the `SSH` configuration of the instance, users will be able to log in to the instance with the private key of the key pair.
        /// * If the instance is already associated with a key, the old key will become invalid.
        /// If you currently use a password to log in, you will no longer be able to do so after you associate the instance with a key.
        /// * Batch operations are supported. The maximum number of instances in each request is 100. If any instance in the request cannot be associated with a key, you will get an error code.
        /// </summary>
        /// <param name="req"><see cref="AssociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="AssociateInstancesKeyPairsResponse"/></returns>
        public AssociateInstancesKeyPairsResponse AssociateInstancesKeyPairsSync(AssociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<AssociateInstancesKeyPairsResponse>(req, "AssociateInstancesKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to associate security groups with specified instances.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// This API is used to associate security groups with specified instances.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure the out-of-band network and deployment network of a CHC host.
        /// </summary>
        /// <param name="req"><see cref="ConfigureChcAssistVpcRequest"/></param>
        /// <returns><see cref="ConfigureChcAssistVpcResponse"/></returns>
        public Task<ConfigureChcAssistVpcResponse> ConfigureChcAssistVpc(ConfigureChcAssistVpcRequest req)
        {
            return InternalRequestAsync<ConfigureChcAssistVpcResponse>(req, "ConfigureChcAssistVpc");
        }

        /// <summary>
        /// This API is used to configure the out-of-band network and deployment network of a CHC host.
        /// </summary>
        /// <param name="req"><see cref="ConfigureChcAssistVpcRequest"/></param>
        /// <returns><see cref="ConfigureChcAssistVpcResponse"/></returns>
        public ConfigureChcAssistVpcResponse ConfigureChcAssistVpcSync(ConfigureChcAssistVpcRequest req)
        {
            return InternalRequestAsync<ConfigureChcAssistVpcResponse>(req, "ConfigureChcAssistVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure the deployment network of a CHC host.
        /// </summary>
        /// <param name="req"><see cref="ConfigureChcDeployVpcRequest"/></param>
        /// <returns><see cref="ConfigureChcDeployVpcResponse"/></returns>
        public Task<ConfigureChcDeployVpcResponse> ConfigureChcDeployVpc(ConfigureChcDeployVpcRequest req)
        {
            return InternalRequestAsync<ConfigureChcDeployVpcResponse>(req, "ConfigureChcDeployVpc");
        }

        /// <summary>
        /// This API is used to configure the deployment network of a CHC host.
        /// </summary>
        /// <param name="req"><see cref="ConfigureChcDeployVpcRequest"/></param>
        /// <returns><see cref="ConfigureChcDeployVpcResponse"/></returns>
        public ConfigureChcDeployVpcResponse ConfigureChcDeployVpcSync(ConfigureChcDeployVpcRequest req)
        {
            return InternalRequestAsync<ConfigureChcDeployVpcResponse>(req, "ConfigureChcDeployVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch the operating system of an instance with CentOS 7 or CentOS 8 as the source operating system.
        /// </summary>
        /// <param name="req"><see cref="ConvertOperatingSystemsRequest"/></param>
        /// <returns><see cref="ConvertOperatingSystemsResponse"/></returns>
        public Task<ConvertOperatingSystemsResponse> ConvertOperatingSystems(ConvertOperatingSystemsRequest req)
        {
            return InternalRequestAsync<ConvertOperatingSystemsResponse>(req, "ConvertOperatingSystems");
        }

        /// <summary>
        /// This API is used to switch the operating system of an instance with CentOS 7 or CentOS 8 as the source operating system.
        /// </summary>
        /// <param name="req"><see cref="ConvertOperatingSystemsRequest"/></param>
        /// <returns><see cref="ConvertOperatingSystemsResponse"/></returns>
        public ConvertOperatingSystemsResponse ConvertOperatingSystemsSync(ConvertOperatingSystemsRequest req)
        {
            return InternalRequestAsync<ConvertOperatingSystemsResponse>(req, "ConvertOperatingSystems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a [spread placement group](https://intl.cloud.tencent.com/document/product/213/15486?from_cn_redirect=1). After you create one, you can specify it for an instance when you [create the instance](https://intl.cloud.tencent.com/document/api/213/15730?from_cn_redirect=1),
        /// </summary>
        /// <param name="req"><see cref="CreateDisasterRecoverGroupRequest"/></param>
        /// <returns><see cref="CreateDisasterRecoverGroupResponse"/></returns>
        public Task<CreateDisasterRecoverGroupResponse> CreateDisasterRecoverGroup(CreateDisasterRecoverGroupRequest req)
        {
            return InternalRequestAsync<CreateDisasterRecoverGroupResponse>(req, "CreateDisasterRecoverGroup");
        }

        /// <summary>
        /// This API is used to create a [spread placement group](https://intl.cloud.tencent.com/document/product/213/15486?from_cn_redirect=1). After you create one, you can specify it for an instance when you [create the instance](https://intl.cloud.tencent.com/document/api/213/15730?from_cn_redirect=1),
        /// </summary>
        /// <param name="req"><see cref="CreateDisasterRecoverGroupRequest"/></param>
        /// <returns><see cref="CreateDisasterRecoverGroupResponse"/></returns>
        public CreateDisasterRecoverGroupResponse CreateDisasterRecoverGroupSync(CreateDisasterRecoverGroupRequest req)
        {
            return InternalRequestAsync<CreateDisasterRecoverGroupResponse>(req, "CreateDisasterRecoverGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a new image with the system disk of an instance. The image can be used to create new instances.
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public Task<CreateImageResponse> CreateImage(CreateImageRequest req)
        {
            return InternalRequestAsync<CreateImageResponse>(req, "CreateImage");
        }

        /// <summary>
        /// This API is used to create a new image with the system disk of an instance. The image can be used to create new instances.
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public CreateImageResponse CreateImageSync(CreateImageRequest req)
        {
            return InternalRequestAsync<CreateImageResponse>(req, "CreateImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an `OpenSSH RSA` key pair, which you can use to log in to a `Linux` instance.
        /// 
        /// * You only need to specify a name, and the system will automatically create a key pair and return its `ID` and the public and private keys.
        /// * The name of the key pair must be unique.
        /// * You can save the private key to a file and use it as an authentication method for `SSH`.
        /// * Tencent Cloud does not save users' private keys. Be sure to save it yourself.
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public Task<CreateKeyPairResponse> CreateKeyPair(CreateKeyPairRequest req)
        {
            return InternalRequestAsync<CreateKeyPairResponse>(req, "CreateKeyPair");
        }

        /// <summary>
        /// This API is used to create an `OpenSSH RSA` key pair, which you can use to log in to a `Linux` instance.
        /// 
        /// * You only need to specify a name, and the system will automatically create a key pair and return its `ID` and the public and private keys.
        /// * The name of the key pair must be unique.
        /// * You can save the private key to a file and use it as an authentication method for `SSH`.
        /// * Tencent Cloud does not save users' private keys. Be sure to save it yourself.
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public CreateKeyPairResponse CreateKeyPairSync(CreateKeyPairRequest req)
        {
            return InternalRequestAsync<CreateKeyPairResponse>(req, "CreateKeyPair")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (CreateLaunchTemplate) is used for instance launch template creation.
        /// 
        /// An instance launch template is a configuration data and can be used to create instances. Its content includes configurations required to create instances, such as instance type, types and sizes of data disk and system disk, and security group and other information.
        /// 
        /// This API is used to create an instance launch template. After the initial creation of the instance template, its template version is the default version 1. A new version can be created using CreateLaunchTemplateVersion (https://intl.cloud.tencent.com/document/product/213/66326?from_cn_redirect=1), and the version number will increment. By default, when specifying an instance launch template in RunInstances (https://intl.cloud.tencent.com/document/product/213/15730?from_cn_redirect=1), if the template version number is not specified, the default version will be used.
        /// </summary>
        /// <param name="req"><see cref="CreateLaunchTemplateRequest"/></param>
        /// <returns><see cref="CreateLaunchTemplateResponse"/></returns>
        public Task<CreateLaunchTemplateResponse> CreateLaunchTemplate(CreateLaunchTemplateRequest req)
        {
            return InternalRequestAsync<CreateLaunchTemplateResponse>(req, "CreateLaunchTemplate");
        }

        /// <summary>
        /// This interface (CreateLaunchTemplate) is used for instance launch template creation.
        /// 
        /// An instance launch template is a configuration data and can be used to create instances. Its content includes configurations required to create instances, such as instance type, types and sizes of data disk and system disk, and security group and other information.
        /// 
        /// This API is used to create an instance launch template. After the initial creation of the instance template, its template version is the default version 1. A new version can be created using CreateLaunchTemplateVersion (https://intl.cloud.tencent.com/document/product/213/66326?from_cn_redirect=1), and the version number will increment. By default, when specifying an instance launch template in RunInstances (https://intl.cloud.tencent.com/document/product/213/15730?from_cn_redirect=1), if the template version number is not specified, the default version will be used.
        /// </summary>
        /// <param name="req"><see cref="CreateLaunchTemplateRequest"/></param>
        /// <returns><see cref="CreateLaunchTemplateResponse"/></returns>
        public CreateLaunchTemplateResponse CreateLaunchTemplateSync(CreateLaunchTemplateRequest req)
        {
            return InternalRequestAsync<CreateLaunchTemplateResponse>(req, "CreateLaunchTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an instance launch template based on the specified template ID and the corresponding template version number. The default version number will be used when no template version numbers are specified. Each instance launch template can have up to 30 version numbers.
        /// </summary>
        /// <param name="req"><see cref="CreateLaunchTemplateVersionRequest"/></param>
        /// <returns><see cref="CreateLaunchTemplateVersionResponse"/></returns>
        public Task<CreateLaunchTemplateVersionResponse> CreateLaunchTemplateVersion(CreateLaunchTemplateVersionRequest req)
        {
            return InternalRequestAsync<CreateLaunchTemplateVersionResponse>(req, "CreateLaunchTemplateVersion");
        }

        /// <summary>
        /// This API is used to create an instance launch template based on the specified template ID and the corresponding template version number. The default version number will be used when no template version numbers are specified. Each instance launch template can have up to 30 version numbers.
        /// </summary>
        /// <param name="req"><see cref="CreateLaunchTemplateVersionRequest"/></param>
        /// <returns><see cref="CreateLaunchTemplateVersionResponse"/></returns>
        public CreateLaunchTemplateVersionResponse CreateLaunchTemplateVersionSync(CreateLaunchTemplateVersionRequest req)
        {
            return InternalRequestAsync<CreateLaunchTemplateVersionResponse>(req, "CreateLaunchTemplateVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a [spread placement group](https://intl.cloud.tencent.com/document/product/213/15486?from_cn_redirect=1). Only empty placement groups can be deleted. To delete a non-empty group, you need to terminate all the CVM instances in it first. Otherwise, the deletion will fail.
        /// </summary>
        /// <param name="req"><see cref="DeleteDisasterRecoverGroupsRequest"/></param>
        /// <returns><see cref="DeleteDisasterRecoverGroupsResponse"/></returns>
        public Task<DeleteDisasterRecoverGroupsResponse> DeleteDisasterRecoverGroups(DeleteDisasterRecoverGroupsRequest req)
        {
            return InternalRequestAsync<DeleteDisasterRecoverGroupsResponse>(req, "DeleteDisasterRecoverGroups");
        }

        /// <summary>
        /// This API is used to delete a [spread placement group](https://intl.cloud.tencent.com/document/product/213/15486?from_cn_redirect=1). Only empty placement groups can be deleted. To delete a non-empty group, you need to terminate all the CVM instances in it first. Otherwise, the deletion will fail.
        /// </summary>
        /// <param name="req"><see cref="DeleteDisasterRecoverGroupsRequest"/></param>
        /// <returns><see cref="DeleteDisasterRecoverGroupsResponse"/></returns>
        public DeleteDisasterRecoverGroupsResponse DeleteDisasterRecoverGroupsSync(DeleteDisasterRecoverGroupsRequest req)
        {
            return InternalRequestAsync<DeleteDisasterRecoverGroupsResponse>(req, "DeleteDisasterRecoverGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or more images.
        /// 
        /// * If the [ImageState](https://intl.cloud.tencent.com/document/product/213/15753?from_cn_redirect=1#Image) of an image is `CREATING` or `USING`, the image cannot be deleted. Call the [DescribeImages](https://intl.cloud.tencent.com/document/api/213/15715?from_cn_redirect=1) API to query the image status.
        /// * Up to 10 custom images are allowed in each region. If you have run out of the quota, delete unused images to create new ones.
        /// * A shared image cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteImagesRequest"/></param>
        /// <returns><see cref="DeleteImagesResponse"/></returns>
        public Task<DeleteImagesResponse> DeleteImages(DeleteImagesRequest req)
        {
            return InternalRequestAsync<DeleteImagesResponse>(req, "DeleteImages");
        }

        /// <summary>
        /// This API is used to delete one or more images.
        /// 
        /// * If the [ImageState](https://intl.cloud.tencent.com/document/product/213/15753?from_cn_redirect=1#Image) of an image is `CREATING` or `USING`, the image cannot be deleted. Call the [DescribeImages](https://intl.cloud.tencent.com/document/api/213/15715?from_cn_redirect=1) API to query the image status.
        /// * Up to 10 custom images are allowed in each region. If you have run out of the quota, delete unused images to create new ones.
        /// * A shared image cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteImagesRequest"/></param>
        /// <returns><see cref="DeleteImagesResponse"/></returns>
        public DeleteImagesResponse DeleteImagesSync(DeleteImagesRequest req)
        {
            return InternalRequestAsync<DeleteImagesResponse>(req, "DeleteImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the key pairs hosted in Tencent Cloud.
        /// 
        /// * You can delete multiple key pairs at the same time.
        /// * A key pair used by an instance or image cannot be deleted. Therefore, you need to verify whether all the key pairs have been deleted successfully.
        /// </summary>
        /// <param name="req"><see cref="DeleteKeyPairsRequest"/></param>
        /// <returns><see cref="DeleteKeyPairsResponse"/></returns>
        public Task<DeleteKeyPairsResponse> DeleteKeyPairs(DeleteKeyPairsRequest req)
        {
            return InternalRequestAsync<DeleteKeyPairsResponse>(req, "DeleteKeyPairs");
        }

        /// <summary>
        /// This API is used to delete the key pairs hosted in Tencent Cloud.
        /// 
        /// * You can delete multiple key pairs at the same time.
        /// * A key pair used by an instance or image cannot be deleted. Therefore, you need to verify whether all the key pairs have been deleted successfully.
        /// </summary>
        /// <param name="req"><see cref="DeleteKeyPairsRequest"/></param>
        /// <returns><see cref="DeleteKeyPairsResponse"/></returns>
        public DeleteKeyPairsResponse DeleteKeyPairsSync(DeleteKeyPairsRequest req)
        {
            return InternalRequestAsync<DeleteKeyPairsResponse>(req, "DeleteKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an instance launch template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLaunchTemplateRequest"/></param>
        /// <returns><see cref="DeleteLaunchTemplateResponse"/></returns>
        public Task<DeleteLaunchTemplateResponse> DeleteLaunchTemplate(DeleteLaunchTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLaunchTemplateResponse>(req, "DeleteLaunchTemplate");
        }

        /// <summary>
        /// This API is used to delete an instance launch template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLaunchTemplateRequest"/></param>
        /// <returns><see cref="DeleteLaunchTemplateResponse"/></returns>
        public DeleteLaunchTemplateResponse DeleteLaunchTemplateSync(DeleteLaunchTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLaunchTemplateResponse>(req, "DeleteLaunchTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or more instance launch template versions.
        /// </summary>
        /// <param name="req"><see cref="DeleteLaunchTemplateVersionsRequest"/></param>
        /// <returns><see cref="DeleteLaunchTemplateVersionsResponse"/></returns>
        public Task<DeleteLaunchTemplateVersionsResponse> DeleteLaunchTemplateVersions(DeleteLaunchTemplateVersionsRequest req)
        {
            return InternalRequestAsync<DeleteLaunchTemplateVersionsResponse>(req, "DeleteLaunchTemplateVersions");
        }

        /// <summary>
        /// This API is used to delete one or more instance launch template versions.
        /// </summary>
        /// <param name="req"><see cref="DeleteLaunchTemplateVersionsRequest"/></param>
        /// <returns><see cref="DeleteLaunchTemplateVersionsResponse"/></returns>
        public DeleteLaunchTemplateVersionsResponse DeleteLaunchTemplateVersionsSync(DeleteLaunchTemplateVersionsRequest req)
        {
            return InternalRequestAsync<DeleteLaunchTemplateVersionsResponse>(req, "DeleteLaunchTemplateVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the actions not allowed for the specified CHC instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeChcDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeChcDeniedActionsResponse"/></returns>
        public Task<DescribeChcDeniedActionsResponse> DescribeChcDeniedActions(DescribeChcDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeChcDeniedActionsResponse>(req, "DescribeChcDeniedActions");
        }

        /// <summary>
        /// This API is used to query the actions not allowed for the specified CHC instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeChcDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeChcDeniedActionsResponse"/></returns>
        public DescribeChcDeniedActionsResponse DescribeChcDeniedActionsSync(DescribeChcDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeChcDeniedActionsResponse>(req, "DescribeChcDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of one or more CHC host.
        /// 
        /// * You can filter the query results with the instance ID, name or device type. See `Filter` for more information.
        /// * If no parameter is defined, a certain number of instances under the current account will be returned. The number is specified by `Limit` and is `20` by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeChcHostsRequest"/></param>
        /// <returns><see cref="DescribeChcHostsResponse"/></returns>
        public Task<DescribeChcHostsResponse> DescribeChcHosts(DescribeChcHostsRequest req)
        {
            return InternalRequestAsync<DescribeChcHostsResponse>(req, "DescribeChcHosts");
        }

        /// <summary>
        /// This API is used to query the details of one or more CHC host.
        /// 
        /// * You can filter the query results with the instance ID, name or device type. See `Filter` for more information.
        /// * If no parameter is defined, a certain number of instances under the current account will be returned. The number is specified by `Limit` and is `20` by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeChcHostsRequest"/></param>
        /// <returns><see cref="DescribeChcHostsResponse"/></returns>
        public DescribeChcHostsResponse DescribeChcHostsSync(DescribeChcHostsRequest req)
        {
            return InternalRequestAsync<DescribeChcHostsResponse>(req, "DescribeChcHosts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the quota of [spread placement groups](https://intl.cloud.tencent.com/document/product/213/15486?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverGroupQuotaRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverGroupQuotaResponse"/></returns>
        public Task<DescribeDisasterRecoverGroupQuotaResponse> DescribeDisasterRecoverGroupQuota(DescribeDisasterRecoverGroupQuotaRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoverGroupQuotaResponse>(req, "DescribeDisasterRecoverGroupQuota");
        }

        /// <summary>
        /// This API is used to query the quota of [spread placement groups](https://intl.cloud.tencent.com/document/product/213/15486?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverGroupQuotaRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverGroupQuotaResponse"/></returns>
        public DescribeDisasterRecoverGroupQuotaResponse DescribeDisasterRecoverGroupQuotaSync(DescribeDisasterRecoverGroupQuotaRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoverGroupQuotaResponse>(req, "DescribeDisasterRecoverGroupQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information on [spread placement groups](https://intl.cloud.tencent.com/document/product/213/15486?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverGroupsRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverGroupsResponse"/></returns>
        public Task<DescribeDisasterRecoverGroupsResponse> DescribeDisasterRecoverGroups(DescribeDisasterRecoverGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoverGroupsResponse>(req, "DescribeDisasterRecoverGroups");
        }

        /// <summary>
        /// This API is used to query the information on [spread placement groups](https://intl.cloud.tencent.com/document/product/213/15486?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverGroupsRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverGroupsResponse"/></returns>
        public DescribeDisasterRecoverGroupsResponse DescribeDisasterRecoverGroupsSync(DescribeDisasterRecoverGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoverGroupsResponse>(req, "DescribeDisasterRecoverGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of CDH instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsRequest"/></param>
        /// <returns><see cref="DescribeHostsResponse"/></returns>
        public Task<DescribeHostsResponse> DescribeHosts(DescribeHostsRequest req)
        {
            return InternalRequestAsync<DescribeHostsResponse>(req, "DescribeHosts");
        }

        /// <summary>
        /// This API is used to query the details of CDH instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsRequest"/></param>
        /// <returns><see cref="DescribeHostsResponse"/></returns>
        public DescribeHostsResponse DescribeHostsSync(DescribeHostsRequest req)
        {
            return InternalRequestAsync<DescribeHostsResponse>(req, "DescribeHosts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view information about available images within an image family.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageFromFamilyRequest"/></param>
        /// <returns><see cref="DescribeImageFromFamilyResponse"/></returns>
        public Task<DescribeImageFromFamilyResponse> DescribeImageFromFamily(DescribeImageFromFamilyRequest req)
        {
            return InternalRequestAsync<DescribeImageFromFamilyResponse>(req, "DescribeImageFromFamily");
        }

        /// <summary>
        /// This API is used to view information about available images within an image family.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageFromFamilyRequest"/></param>
        /// <returns><see cref="DescribeImageFromFamilyResponse"/></returns>
        public DescribeImageFromFamilyResponse DescribeImageFromFamilySync(DescribeImageFromFamilyRequest req)
        {
            return InternalRequestAsync<DescribeImageFromFamilyResponse>(req, "DescribeImageFromFamily")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the image quota of an user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageQuotaRequest"/></param>
        /// <returns><see cref="DescribeImageQuotaResponse"/></returns>
        public Task<DescribeImageQuotaResponse> DescribeImageQuota(DescribeImageQuotaRequest req)
        {
            return InternalRequestAsync<DescribeImageQuotaResponse>(req, "DescribeImageQuota");
        }

        /// <summary>
        /// This API is used to query the image quota of an user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageQuotaRequest"/></param>
        /// <returns><see cref="DescribeImageQuotaResponse"/></returns>
        public DescribeImageQuotaResponse DescribeImageQuotaSync(DescribeImageQuotaRequest req)
        {
            return InternalRequestAsync<DescribeImageQuotaResponse>(req, "DescribeImageQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query image sharing information.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSharePermissionRequest"/></param>
        /// <returns><see cref="DescribeImageSharePermissionResponse"/></returns>
        public Task<DescribeImageSharePermissionResponse> DescribeImageSharePermission(DescribeImageSharePermissionRequest req)
        {
            return InternalRequestAsync<DescribeImageSharePermissionResponse>(req, "DescribeImageSharePermission");
        }

        /// <summary>
        /// This API is used to query image sharing information.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSharePermissionRequest"/></param>
        /// <returns><see cref="DescribeImageSharePermissionResponse"/></returns>
        public DescribeImageSharePermissionResponse DescribeImageSharePermissionSync(DescribeImageSharePermissionRequest req)
        {
            return InternalRequestAsync<DescribeImageSharePermissionResponse>(req, "DescribeImageSharePermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the list of images.
        /// 
        /// * You specify the image ID or set filters to query the details of certain images.
        /// * You can specify `Offset` and `Limit` to select a certain part of the results. By default, the information on the first 20 matching results is returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages");
        }

        /// <summary>
        /// This API is used to view the list of images.
        /// 
        /// * You specify the image ID or set filters to query the details of certain images.
        /// * You can specify `Offset` and `Limit` to select a certain part of the results. By default, the information on the first 20 matching results is returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of supported operating systems of imported images.
        /// </summary>
        /// <param name="req"><see cref="DescribeImportImageOsRequest"/></param>
        /// <returns><see cref="DescribeImportImageOsResponse"/></returns>
        public Task<DescribeImportImageOsResponse> DescribeImportImageOs(DescribeImportImageOsRequest req)
        {
            return InternalRequestAsync<DescribeImportImageOsResponse>(req, "DescribeImportImageOs");
        }

        /// <summary>
        /// This API is used to query the list of supported operating systems of imported images.
        /// </summary>
        /// <param name="req"><see cref="DescribeImportImageOsRequest"/></param>
        /// <returns><see cref="DescribeImportImageOsResponse"/></returns>
        public DescribeImportImageOsResponse DescribeImportImageOsSync(DescribeImportImageOsRequest req)
        {
            return InternalRequestAsync<DescribeImportImageOsResponse>(req, "DescribeImportImageOs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a list of model families available to the current user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceFamilyConfigsRequest"/></param>
        /// <returns><see cref="DescribeInstanceFamilyConfigsResponse"/></returns>
        public Task<DescribeInstanceFamilyConfigsResponse> DescribeInstanceFamilyConfigs(DescribeInstanceFamilyConfigsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceFamilyConfigsResponse>(req, "DescribeInstanceFamilyConfigs");
        }

        /// <summary>
        /// This API is used to query a list of model families available to the current user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceFamilyConfigsRequest"/></param>
        /// <returns><see cref="DescribeInstanceFamilyConfigsResponse"/></returns>
        public DescribeInstanceFamilyConfigsResponse DescribeInstanceFamilyConfigsSync(DescribeInstanceFamilyConfigsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceFamilyConfigsResponse>(req, "DescribeInstanceFamilyConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of instances.
        /// 
        /// * You can filter the query results with the instance `ID`, name, or billing method. See `Filter` for more information.
        /// * If no parameter is defined, a certain number of instances under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to query the details of instances.
        /// 
        /// * You can filter the query results with the instance `ID`, name, or billing method. See `Filter` for more information.
        /// * If no parameter is defined, a certain number of instances under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the attributes of specified instances. Currently, it supports querying the custom data UserData of instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesAttributesRequest"/></param>
        /// <returns><see cref="DescribeInstancesAttributesResponse"/></returns>
        public Task<DescribeInstancesAttributesResponse> DescribeInstancesAttributes(DescribeInstancesAttributesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesAttributesResponse>(req, "DescribeInstancesAttributes");
        }

        /// <summary>
        /// This API is used to obtain the attributes of specified instances. Currently, it supports querying the custom data UserData of instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesAttributesRequest"/></param>
        /// <returns><see cref="DescribeInstancesAttributesResponse"/></returns>
        public DescribeInstancesAttributesResponse DescribeInstancesAttributesSync(DescribeInstancesAttributesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesAttributesResponse>(req, "DescribeInstancesAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query limitations on operations on an instance.
        /// 
        /// * Currently you can use this API to query the maximum number of times you can modify the configuration of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesOperationLimitRequest"/></param>
        /// <returns><see cref="DescribeInstancesOperationLimitResponse"/></returns>
        public Task<DescribeInstancesOperationLimitResponse> DescribeInstancesOperationLimit(DescribeInstancesOperationLimitRequest req)
        {
            return InternalRequestAsync<DescribeInstancesOperationLimitResponse>(req, "DescribeInstancesOperationLimit");
        }

        /// <summary>
        /// This API is used to query limitations on operations on an instance.
        /// 
        /// * Currently you can use this API to query the maximum number of times you can modify the configuration of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesOperationLimitRequest"/></param>
        /// <returns><see cref="DescribeInstancesOperationLimitResponse"/></returns>
        public DescribeInstancesOperationLimitResponse DescribeInstancesOperationLimitSync(DescribeInstancesOperationLimitRequest req)
        {
            return InternalRequestAsync<DescribeInstancesOperationLimitResponse>(req, "DescribeInstancesOperationLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of instances.
        /// 
        /// * You can query the status of an instance with its `ID`.
        /// * If no parameter is defined, the status of a certain number of instances under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesStatusRequest"/></param>
        /// <returns><see cref="DescribeInstancesStatusResponse"/></returns>
        public Task<DescribeInstancesStatusResponse> DescribeInstancesStatus(DescribeInstancesStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstancesStatusResponse>(req, "DescribeInstancesStatus");
        }

        /// <summary>
        /// This API is used to query the status of instances.
        /// 
        /// * You can query the status of an instance with its `ID`.
        /// * If no parameter is defined, the status of a certain number of instances under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesStatusRequest"/></param>
        /// <returns><see cref="DescribeInstancesStatusResponse"/></returns>
        public DescribeInstancesStatusResponse DescribeInstancesStatusSync(DescribeInstancesStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstancesStatusResponse>(req, "DescribeInstancesStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the network billing methods.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetChargeTypeConfigsRequest"/></param>
        /// <returns><see cref="DescribeInternetChargeTypeConfigsResponse"/></returns>
        public Task<DescribeInternetChargeTypeConfigsResponse> DescribeInternetChargeTypeConfigs(DescribeInternetChargeTypeConfigsRequest req)
        {
            return InternalRequestAsync<DescribeInternetChargeTypeConfigsResponse>(req, "DescribeInternetChargeTypeConfigs");
        }

        /// <summary>
        /// This API is used to query the network billing methods.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetChargeTypeConfigsRequest"/></param>
        /// <returns><see cref="DescribeInternetChargeTypeConfigsResponse"/></returns>
        public DescribeInternetChargeTypeConfigsResponse DescribeInternetChargeTypeConfigsSync(DescribeInternetChargeTypeConfigsRequest req)
        {
            return InternalRequestAsync<DescribeInternetChargeTypeConfigsResponse>(req, "DescribeInternetChargeTypeConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query key pairs.
        /// 
        /// * A key pair is a pair of keys generated by an algorithm in which the public key is available to the public and the private key is available only to the user. You can use this API to query the public key but not the private key.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyPairsRequest"/></param>
        /// <returns><see cref="DescribeKeyPairsResponse"/></returns>
        public Task<DescribeKeyPairsResponse> DescribeKeyPairs(DescribeKeyPairsRequest req)
        {
            return InternalRequestAsync<DescribeKeyPairsResponse>(req, "DescribeKeyPairs");
        }

        /// <summary>
        /// This API is used to query key pairs.
        /// 
        /// * A key pair is a pair of keys generated by an algorithm in which the public key is available to the public and the private key is available only to the user. You can use this API to query the public key but not the private key.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyPairsRequest"/></param>
        /// <returns><see cref="DescribeKeyPairsResponse"/></returns>
        public DescribeKeyPairsResponse DescribeKeyPairsSync(DescribeKeyPairsRequest req)
        {
            return InternalRequestAsync<DescribeKeyPairsResponse>(req, "DescribeKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of instance launch template versions.
        /// </summary>
        /// <param name="req"><see cref="DescribeLaunchTemplateVersionsRequest"/></param>
        /// <returns><see cref="DescribeLaunchTemplateVersionsResponse"/></returns>
        public Task<DescribeLaunchTemplateVersionsResponse> DescribeLaunchTemplateVersions(DescribeLaunchTemplateVersionsRequest req)
        {
            return InternalRequestAsync<DescribeLaunchTemplateVersionsResponse>(req, "DescribeLaunchTemplateVersions");
        }

        /// <summary>
        /// This API is used to query the information of instance launch template versions.
        /// </summary>
        /// <param name="req"><see cref="DescribeLaunchTemplateVersionsRequest"/></param>
        /// <returns><see cref="DescribeLaunchTemplateVersionsResponse"/></returns>
        public DescribeLaunchTemplateVersionsResponse DescribeLaunchTemplateVersionsSync(DescribeLaunchTemplateVersionsRequest req)
        {
            return InternalRequestAsync<DescribeLaunchTemplateVersionsResponse>(req, "DescribeLaunchTemplateVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query one or more instance launch templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeLaunchTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLaunchTemplatesResponse"/></returns>
        public Task<DescribeLaunchTemplatesResponse> DescribeLaunchTemplates(DescribeLaunchTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLaunchTemplatesResponse>(req, "DescribeLaunchTemplates");
        }

        /// <summary>
        /// This API is used to query one or more instance launch templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeLaunchTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLaunchTemplatesResponse"/></returns>
        public DescribeLaunchTemplatesResponse DescribeLaunchTemplatesSync(DescribeLaunchTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLaunchTemplatesResponse>(req, "DescribeLaunchTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is suspended. To query the information of regions, use [DescribeZones](https://intl.cloud.tencent.com/document/product/1596/77930?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// This API is suspended. To query the information of regions, use [DescribeZones](https://intl.cloud.tencent.com/document/product/1596/77930?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list the reserved instances purchased by the user.
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedInstancesRequest"/></param>
        /// <returns><see cref="DescribeReservedInstancesResponse"/></returns>
        public Task<DescribeReservedInstancesResponse> DescribeReservedInstances(DescribeReservedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeReservedInstancesResponse>(req, "DescribeReservedInstances");
        }

        /// <summary>
        /// This API is used to list the reserved instances purchased by the user.
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedInstancesRequest"/></param>
        /// <returns><see cref="DescribeReservedInstancesResponse"/></returns>
        public DescribeReservedInstancesResponse DescribeReservedInstancesSync(DescribeReservedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeReservedInstancesResponse>(req, "DescribeReservedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to describe reserved instance (RI) offerings.
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedInstancesConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeReservedInstancesConfigInfosResponse"/></returns>
        public Task<DescribeReservedInstancesConfigInfosResponse> DescribeReservedInstancesConfigInfos(DescribeReservedInstancesConfigInfosRequest req)
        {
            return InternalRequestAsync<DescribeReservedInstancesConfigInfosResponse>(req, "DescribeReservedInstancesConfigInfos");
        }

        /// <summary>
        /// This API is used to describe reserved instance (RI) offerings.
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedInstancesConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeReservedInstancesConfigInfosResponse"/></returns>
        public DescribeReservedInstancesConfigInfosResponse DescribeReservedInstancesConfigInfosSync(DescribeReservedInstancesConfigInfosRequest req)
        {
            return InternalRequestAsync<DescribeReservedInstancesConfigInfosResponse>(req, "DescribeReservedInstancesConfigInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to describe Reserved Instance offerings that are available for purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedInstancesOfferingsRequest"/></param>
        /// <returns><see cref="DescribeReservedInstancesOfferingsResponse"/></returns>
        public Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest req)
        {
            return InternalRequestAsync<DescribeReservedInstancesOfferingsResponse>(req, "DescribeReservedInstancesOfferings");
        }

        /// <summary>
        /// This API is used to describe Reserved Instance offerings that are available for purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedInstancesOfferingsRequest"/></param>
        /// <returns><see cref="DescribeReservedInstancesOfferingsResponse"/></returns>
        public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferingsSync(DescribeReservedInstancesOfferingsRequest req)
        {
            return InternalRequestAsync<DescribeReservedInstancesOfferingsResponse>(req, "DescribeReservedInstancesOfferings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the configurations of models in an availability zone.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeZoneInstanceConfigInfosResponse"/></returns>
        public Task<DescribeZoneInstanceConfigInfosResponse> DescribeZoneInstanceConfigInfos(DescribeZoneInstanceConfigInfosRequest req)
        {
            return InternalRequestAsync<DescribeZoneInstanceConfigInfosResponse>(req, "DescribeZoneInstanceConfigInfos");
        }

        /// <summary>
        /// This API is used to query the configurations of models in an availability zone.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeZoneInstanceConfigInfosResponse"/></returns>
        public DescribeZoneInstanceConfigInfosResponse DescribeZoneInstanceConfigInfosSync(DescribeZoneInstanceConfigInfosRequest req)
        {
            return InternalRequestAsync<DescribeZoneInstanceConfigInfosResponse>(req, "DescribeZoneInstanceConfigInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query availability zones.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// This API is used to query availability zones.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind one or more key pairs from one or more instances.
        /// 
        /// * It only supports [`STOPPED`](https://intl.cloud.tencent.com/document/product/213/15753?from_cn_redirect=1#InstanceStatus) Linux instances.
        /// * After a key pair is disassociated from an instance, you can log in to the instance with password.
        /// * If you did not set a password for the instance, you will not be able to log in via SSH after the unbinding. In this case, you can call [ResetInstancesPassword](https://intl.cloud.tencent.com/document/api/213/15736?from_cn_redirect=1) to set a login password.
        /// * Batch operations are supported. The maximum number of instances in each request is 100. If instances not available for the operation are selected, you will get an error code.
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public Task<DisassociateInstancesKeyPairsResponse> DisassociateInstancesKeyPairs(DisassociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<DisassociateInstancesKeyPairsResponse>(req, "DisassociateInstancesKeyPairs");
        }

        /// <summary>
        /// This API is used to unbind one or more key pairs from one or more instances.
        /// 
        /// * It only supports [`STOPPED`](https://intl.cloud.tencent.com/document/product/213/15753?from_cn_redirect=1#InstanceStatus) Linux instances.
        /// * After a key pair is disassociated from an instance, you can log in to the instance with password.
        /// * If you did not set a password for the instance, you will not be able to log in via SSH after the unbinding. In this case, you can call [ResetInstancesPassword](https://intl.cloud.tencent.com/document/api/213/15736?from_cn_redirect=1) to set a login password.
        /// * Batch operations are supported. The maximum number of instances in each request is 100. If instances not available for the operation are selected, you will get an error code.
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public DisassociateInstancesKeyPairsResponse DisassociateInstancesKeyPairsSync(DisassociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<DisassociateInstancesKeyPairsResponse>(req, "DisassociateInstancesKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disassociate security groups from instances.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups");
        }

        /// <summary>
        /// This API is used to disassociate security groups from instances.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enter the rescue mode.
        /// </summary>
        /// <param name="req"><see cref="EnterRescueModeRequest"/></param>
        /// <returns><see cref="EnterRescueModeResponse"/></returns>
        public Task<EnterRescueModeResponse> EnterRescueMode(EnterRescueModeRequest req)
        {
            return InternalRequestAsync<EnterRescueModeResponse>(req, "EnterRescueMode");
        }

        /// <summary>
        /// This API is used to enter the rescue mode.
        /// </summary>
        /// <param name="req"><see cref="EnterRescueModeRequest"/></param>
        /// <returns><see cref="EnterRescueModeResponse"/></returns>
        public EnterRescueModeResponse EnterRescueModeSync(EnterRescueModeRequest req)
        {
            return InternalRequestAsync<EnterRescueModeResponse>(req, "EnterRescueMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to exit the rescue mode.
        /// </summary>
        /// <param name="req"><see cref="ExitRescueModeRequest"/></param>
        /// <returns><see cref="ExitRescueModeResponse"/></returns>
        public Task<ExitRescueModeResponse> ExitRescueMode(ExitRescueModeRequest req)
        {
            return InternalRequestAsync<ExitRescueModeResponse>(req, "ExitRescueMode");
        }

        /// <summary>
        /// This API is used to exit the rescue mode.
        /// </summary>
        /// <param name="req"><see cref="ExitRescueModeRequest"/></param>
        /// <returns><see cref="ExitRescueModeResponse"/></returns>
        public ExitRescueModeResponse ExitRescueModeSync(ExitRescueModeRequest req)
        {
            return InternalRequestAsync<ExitRescueModeResponse>(req, "ExitRescueMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export custom images to the specified COS bucket.
        /// </summary>
        /// <param name="req"><see cref="ExportImagesRequest"/></param>
        /// <returns><see cref="ExportImagesResponse"/></returns>
        public Task<ExportImagesResponse> ExportImages(ExportImagesRequest req)
        {
            return InternalRequestAsync<ExportImagesResponse>(req, "ExportImages");
        }

        /// <summary>
        /// This API is used to export custom images to the specified COS bucket.
        /// </summary>
        /// <param name="req"><see cref="ExportImagesRequest"/></param>
        /// <returns><see cref="ExportImagesResponse"/></returns>
        public ExportImagesResponse ExportImagesSync(ExportImagesRequest req)
        {
            return InternalRequestAsync<ExportImagesResponse>(req, "ExportImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to import an image. The image imported can be used to create instances. Currently, this API supports RAW, VHD, QCOW2, and VMDK image formats.
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public Task<ImportImageResponse> ImportImage(ImportImageRequest req)
        {
            return InternalRequestAsync<ImportImageResponse>(req, "ImportImage");
        }

        /// <summary>
        /// This API is used to import an image. The image imported can be used to create instances. Currently, this API supports RAW, VHD, QCOW2, and VMDK image formats.
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public ImportImageResponse ImportImageSync(ImportImageRequest req)
        {
            return InternalRequestAsync<ImportImageResponse>(req, "ImportImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to import key pairs.
        /// 
        /// * You can use this API to import key pairs to a user account, but the key pairs will not be automatically associated with any instance. You may use [AssociasteInstancesKeyPair](https://intl.cloud.tencent.com/document/api/213/15698?from_cn_redirect=1) to associate key pairs with instances.
        /// * You need to specify the names of the key pairs and the content of the public keys.
        /// * If you only have private keys, you can convert them to public keys with the `SSL` tool before importing them.
        /// </summary>
        /// <param name="req"><see cref="ImportKeyPairRequest"/></param>
        /// <returns><see cref="ImportKeyPairResponse"/></returns>
        public Task<ImportKeyPairResponse> ImportKeyPair(ImportKeyPairRequest req)
        {
            return InternalRequestAsync<ImportKeyPairResponse>(req, "ImportKeyPair");
        }

        /// <summary>
        /// This API is used to import key pairs.
        /// 
        /// * You can use this API to import key pairs to a user account, but the key pairs will not be automatically associated with any instance. You may use [AssociasteInstancesKeyPair](https://intl.cloud.tencent.com/document/api/213/15698?from_cn_redirect=1) to associate key pairs with instances.
        /// * You need to specify the names of the key pairs and the content of the public keys.
        /// * If you only have private keys, you can convert them to public keys with the `SSL` tool before importing them.
        /// </summary>
        /// <param name="req"><see cref="ImportKeyPairRequest"/></param>
        /// <returns><see cref="ImportKeyPairResponse"/></returns>
        public ImportKeyPairResponse ImportKeyPairSync(ImportKeyPairRequest req)
        {
            return InternalRequestAsync<ImportKeyPairResponse>(req, "ImportKeyPair")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of reserved instances. It only supports querying purchasable reserved instance offerings. Currently, RIs are only offered to beta users.
        /// </summary>
        /// <param name="req"><see cref="InquirePricePurchaseReservedInstancesOfferingRequest"/></param>
        /// <returns><see cref="InquirePricePurchaseReservedInstancesOfferingResponse"/></returns>
        public Task<InquirePricePurchaseReservedInstancesOfferingResponse> InquirePricePurchaseReservedInstancesOffering(InquirePricePurchaseReservedInstancesOfferingRequest req)
        {
            return InternalRequestAsync<InquirePricePurchaseReservedInstancesOfferingResponse>(req, "InquirePricePurchaseReservedInstancesOffering");
        }

        /// <summary>
        /// This API is used to query the price of reserved instances. It only supports querying purchasable reserved instance offerings. Currently, RIs are only offered to beta users.
        /// </summary>
        /// <param name="req"><see cref="InquirePricePurchaseReservedInstancesOfferingRequest"/></param>
        /// <returns><see cref="InquirePricePurchaseReservedInstancesOfferingResponse"/></returns>
        public InquirePricePurchaseReservedInstancesOfferingResponse InquirePricePurchaseReservedInstancesOfferingSync(InquirePricePurchaseReservedInstancesOfferingRequest req)
        {
            return InternalRequestAsync<InquirePricePurchaseReservedInstancesOfferingResponse>(req, "InquirePricePurchaseReservedInstancesOffering")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to inquire about the price for reinstalling an instance.
        /// 
        /// * If you have specified the parameter `ImageId`, inquire about the price for reinstallation by using the specified image. Otherwise, inquire about the price for reinstallation based on the image currently used by the instance.
        /// * Currently, only instances with a [system disk type](https://intl.cloud.tencent.com/document/api/213/15753?from_cn_redirect=1#SystemDisk) of `CLOUD_BSSD`, `CLOUD_PREMIUM`, or `CLOUD_SSD` are supported for inquiring about the price for reinstallation caused by switching between `Linux` and `Windows` operating systems through this API.
        /// * Currently, instances in regions outside the Chinese mainland are not supported for inquiring about the price for reinstallation caused by switching between `Linux` and `Windows` operating systems through this API.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstanceResponse"/></returns>
        public Task<InquiryPriceResetInstanceResponse> InquiryPriceResetInstance(InquiryPriceResetInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceResetInstanceResponse>(req, "InquiryPriceResetInstance");
        }

        /// <summary>
        /// This API is used to inquire about the price for reinstalling an instance.
        /// 
        /// * If you have specified the parameter `ImageId`, inquire about the price for reinstallation by using the specified image. Otherwise, inquire about the price for reinstallation based on the image currently used by the instance.
        /// * Currently, only instances with a [system disk type](https://intl.cloud.tencent.com/document/api/213/15753?from_cn_redirect=1#SystemDisk) of `CLOUD_BSSD`, `CLOUD_PREMIUM`, or `CLOUD_SSD` are supported for inquiring about the price for reinstallation caused by switching between `Linux` and `Windows` operating systems through this API.
        /// * Currently, instances in regions outside the Chinese mainland are not supported for inquiring about the price for reinstallation caused by switching between `Linux` and `Windows` operating systems through this API.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstanceResponse"/></returns>
        public InquiryPriceResetInstanceResponse InquiryPriceResetInstanceSync(InquiryPriceResetInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceResetInstanceResponse>(req, "InquiryPriceResetInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price for upgrading the public bandwidth cap of an instance.
        /// 
        /// * The allowed bandwidth cap varies for different models. For details, see [Purchasing Network Bandwidth](https://intl.cloud.tencent.com/document/product/213/509?from_cn_redirect=1).
        /// * For bandwidth billed by the `TRAFFIC_POSTPAID_BY_HOUR` method, changing the bandwidth cap through this API takes effect in real time. You can increase or reduce bandwidth within applicable limits.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstancesInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstancesInternetMaxBandwidthResponse"/></returns>
        public Task<InquiryPriceResetInstancesInternetMaxBandwidthResponse> InquiryPriceResetInstancesInternetMaxBandwidth(InquiryPriceResetInstancesInternetMaxBandwidthRequest req)
        {
            return InternalRequestAsync<InquiryPriceResetInstancesInternetMaxBandwidthResponse>(req, "InquiryPriceResetInstancesInternetMaxBandwidth");
        }

        /// <summary>
        /// This API is used to query the price for upgrading the public bandwidth cap of an instance.
        /// 
        /// * The allowed bandwidth cap varies for different models. For details, see [Purchasing Network Bandwidth](https://intl.cloud.tencent.com/document/product/213/509?from_cn_redirect=1).
        /// * For bandwidth billed by the `TRAFFIC_POSTPAID_BY_HOUR` method, changing the bandwidth cap through this API takes effect in real time. You can increase or reduce bandwidth within applicable limits.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstancesInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstancesInternetMaxBandwidthResponse"/></returns>
        public InquiryPriceResetInstancesInternetMaxBandwidthResponse InquiryPriceResetInstancesInternetMaxBandwidthSync(InquiryPriceResetInstancesInternetMaxBandwidthRequest req)
        {
            return InternalRequestAsync<InquiryPriceResetInstancesInternetMaxBandwidthResponse>(req, "InquiryPriceResetInstancesInternetMaxBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price for adjusting the instance model.
        /// 
        /// * Currently, you can only use this API to query the prices of instances whose [system disk type](https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`.
        /// * Currently, you cannot use this API to query the prices of [CDH](https://intl.cloud.tencent.com/document/product/416?from_cn_redirect=1) instances.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstancesTypeRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstancesTypeResponse"/></returns>
        public Task<InquiryPriceResetInstancesTypeResponse> InquiryPriceResetInstancesType(InquiryPriceResetInstancesTypeRequest req)
        {
            return InternalRequestAsync<InquiryPriceResetInstancesTypeResponse>(req, "InquiryPriceResetInstancesType");
        }

        /// <summary>
        /// This API is used to query the price for adjusting the instance model.
        /// 
        /// * Currently, you can only use this API to query the prices of instances whose [system disk type](https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`.
        /// * Currently, you cannot use this API to query the prices of [CDH](https://intl.cloud.tencent.com/document/product/416?from_cn_redirect=1) instances.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstancesTypeRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstancesTypeResponse"/></returns>
        public InquiryPriceResetInstancesTypeResponse InquiryPriceResetInstancesTypeSync(InquiryPriceResetInstancesTypeRequest req)
        {
            return InternalRequestAsync<InquiryPriceResetInstancesTypeResponse>(req, "InquiryPriceResetInstancesType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price for expanding data disks of an instance.
        /// 
        /// * Currently, you can only use this API to query the price of non-elastic data disks whose [disk type](https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`. You can use [`DescribeDisks`](https://intl.cloud.tencent.com/document/api/362/16315?from_cn_redirect=1) to check whether a disk is elastic. If the `Portable` field in the response is `false`, it means that the disk is non-elastic.
        /// * Currently, you cannot use this API to query the price for [CDH](https://intl.cloud.tencent.com/document/product/416?from_cn_redirect=1) instances. *Also, you can only query the price of expanding one data disk at a time.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResizeInstanceDisksRequest"/></param>
        /// <returns><see cref="InquiryPriceResizeInstanceDisksResponse"/></returns>
        public Task<InquiryPriceResizeInstanceDisksResponse> InquiryPriceResizeInstanceDisks(InquiryPriceResizeInstanceDisksRequest req)
        {
            return InternalRequestAsync<InquiryPriceResizeInstanceDisksResponse>(req, "InquiryPriceResizeInstanceDisks");
        }

        /// <summary>
        /// This API is used to query the price for expanding data disks of an instance.
        /// 
        /// * Currently, you can only use this API to query the price of non-elastic data disks whose [disk type](https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`. You can use [`DescribeDisks`](https://intl.cloud.tencent.com/document/api/362/16315?from_cn_redirect=1) to check whether a disk is elastic. If the `Portable` field in the response is `false`, it means that the disk is non-elastic.
        /// * Currently, you cannot use this API to query the price for [CDH](https://intl.cloud.tencent.com/document/product/416?from_cn_redirect=1) instances. *Also, you can only query the price of expanding one data disk at a time.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResizeInstanceDisksRequest"/></param>
        /// <returns><see cref="InquiryPriceResizeInstanceDisksResponse"/></returns>
        public InquiryPriceResizeInstanceDisksResponse InquiryPriceResizeInstanceDisksSync(InquiryPriceResizeInstanceDisksRequest req)
        {
            return InternalRequestAsync<InquiryPriceResizeInstanceDisksResponse>(req, "InquiryPriceResizeInstanceDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of creating instances. You can only use this API for instances whose configuration is within the purchase limit. For more information, see [RunInstances](https://intl.cloud.tencent.com/document/api/213/15730?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRunInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceRunInstancesResponse"/></returns>
        public Task<InquiryPriceRunInstancesResponse> InquiryPriceRunInstances(InquiryPriceRunInstancesRequest req)
        {
            return InternalRequestAsync<InquiryPriceRunInstancesResponse>(req, "InquiryPriceRunInstances");
        }

        /// <summary>
        /// This API is used to query the price of creating instances. You can only use this API for instances whose configuration is within the purchase limit. For more information, see [RunInstances](https://intl.cloud.tencent.com/document/api/213/15730?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRunInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceRunInstancesResponse"/></returns>
        public InquiryPriceRunInstancesResponse InquiryPriceRunInstancesSync(InquiryPriceRunInstancesRequest req)
        {
            return InternalRequestAsync<InquiryPriceRunInstancesResponse>(req, "InquiryPriceRunInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the CHC host attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyChcAttributeRequest"/></param>
        /// <returns><see cref="ModifyChcAttributeResponse"/></returns>
        public Task<ModifyChcAttributeResponse> ModifyChcAttribute(ModifyChcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyChcAttributeResponse>(req, "ModifyChcAttribute");
        }

        /// <summary>
        /// This API is used to modify the CHC host attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyChcAttributeRequest"/></param>
        /// <returns><see cref="ModifyChcAttributeResponse"/></returns>
        public ModifyChcAttributeResponse ModifyChcAttributeSync(ModifyChcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyChcAttributeResponse>(req, "ModifyChcAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of [spread placement groups](https://intl.cloud.tencent.com/document/product/213/15486?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyDisasterRecoverGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyDisasterRecoverGroupAttributeResponse"/></returns>
        public Task<ModifyDisasterRecoverGroupAttributeResponse> ModifyDisasterRecoverGroupAttribute(ModifyDisasterRecoverGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDisasterRecoverGroupAttributeResponse>(req, "ModifyDisasterRecoverGroupAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of [spread placement groups](https://intl.cloud.tencent.com/document/product/213/15486?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyDisasterRecoverGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyDisasterRecoverGroupAttributeResponse"/></returns>
        public ModifyDisasterRecoverGroupAttributeResponse ModifyDisasterRecoverGroupAttributeSync(ModifyDisasterRecoverGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDisasterRecoverGroupAttributeResponse>(req, "ModifyDisasterRecoverGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a CDH instance, such as instance name and renewal flag. One of the two parameters, HostName and RenewFlag, must be set, but you cannot set both of them at the same time.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsAttributeRequest"/></param>
        /// <returns><see cref="ModifyHostsAttributeResponse"/></returns>
        public Task<ModifyHostsAttributeResponse> ModifyHostsAttribute(ModifyHostsAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHostsAttributeResponse>(req, "ModifyHostsAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a CDH instance, such as instance name and renewal flag. One of the two parameters, HostName and RenewFlag, must be set, but you cannot set both of them at the same time.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsAttributeRequest"/></param>
        /// <returns><see cref="ModifyHostsAttributeResponse"/></returns>
        public ModifyHostsAttributeResponse ModifyHostsAttributeSync(ModifyHostsAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHostsAttributeResponse>(req, "ModifyHostsAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify image attributes.
        /// 
        /// * Attributes of shared images cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyImageAttributeResponse"/></returns>
        public Task<ModifyImageAttributeResponse> ModifyImageAttribute(ModifyImageAttributeRequest req)
        {
            return InternalRequestAsync<ModifyImageAttributeResponse>(req, "ModifyImageAttribute");
        }

        /// <summary>
        /// This API is used to modify image attributes.
        /// 
        /// * Attributes of shared images cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyImageAttributeResponse"/></returns>
        public ModifyImageAttributeResponse ModifyImageAttributeSync(ModifyImageAttributeRequest req)
        {
            return InternalRequestAsync<ModifyImageAttributeResponse>(req, "ModifyImageAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify image sharing information.
        /// 
        /// * The account with shared image access can use the image to create instances.
        /// * Each custom image can be shared with a maximum of 500 accounts.
        /// * Shared images cannot have their names or description changed. They can only be used to create instances.
        /// * Sharing is only supported within the same region as the recipient's account.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSharePermissionRequest"/></param>
        /// <returns><see cref="ModifyImageSharePermissionResponse"/></returns>
        public Task<ModifyImageSharePermissionResponse> ModifyImageSharePermission(ModifyImageSharePermissionRequest req)
        {
            return InternalRequestAsync<ModifyImageSharePermissionResponse>(req, "ModifyImageSharePermission");
        }

        /// <summary>
        /// This API is used to modify image sharing information.
        /// 
        /// * The account with shared image access can use the image to create instances.
        /// * Each custom image can be shared with a maximum of 500 accounts.
        /// * Shared images cannot have their names or description changed. They can only be used to create instances.
        /// * Sharing is only supported within the same region as the recipient's account.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSharePermissionRequest"/></param>
        /// <returns><see cref="ModifyImageSharePermissionResponse"/></returns>
        public ModifyImageSharePermissionResponse ModifyImageSharePermissionSync(ModifyImageSharePermissionRequest req)
        {
            return InternalRequestAsync<ModifyImageSharePermissionResponse>(req, "ModifyImageSharePermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The API is used to modify the attributes of an instance. Only the name and the associated security groups can be modified for now.
        /// 
        /// * An attribute must be specified in the request.
        /// * "Instance name" is a custom name for easier management. Tencent Cloud does not use the name for online support or instance management.
        /// * Batch operations are supported. Each request can modify up to 100 instances.
        /// * When you modify the security groups associated with an instance is modified, the original security groups are disassociated.
        /// * You can use the API [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) to query the instance operation result. If the 'LatestOperationState' in the response is **SUCCESS**, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public Task<ModifyInstancesAttributeResponse> ModifyInstancesAttribute(ModifyInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesAttributeResponse>(req, "ModifyInstancesAttribute");
        }

        /// <summary>
        /// The API is used to modify the attributes of an instance. Only the name and the associated security groups can be modified for now.
        /// 
        /// * An attribute must be specified in the request.
        /// * "Instance name" is a custom name for easier management. Tencent Cloud does not use the name for online support or instance management.
        /// * Batch operations are supported. Each request can modify up to 100 instances.
        /// * When you modify the security groups associated with an instance is modified, the original security groups are disassociated.
        /// * You can use the API [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) to query the instance operation result. If the 'LatestOperationState' in the response is **SUCCESS**, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public ModifyInstancesAttributeResponse ModifyInstancesAttributeSync(ModifyInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesAttributeResponse>(req, "ModifyInstancesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the project to which an instance is assigned.
        /// 
        /// * Project is a virtual concept. You can create multiple projects under one account, manage different resources in each project, and assign different instances to different projects. You may use the [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1) API to query instances and use the project ID to filter the results.
        /// * You cannot modify the project of an instance that is bound to a load balancer. You need to unbind the load balancer from the instance by using the [DeregisterInstancesFromLoadBalancer](https://intl.cloud.tencent.com/document/api/214/1258?from_cn_redirect=1) API before using this API.
        /// * Batch operations are supported. Up to 100 instances per request is allowed.
        /// * You can use the API [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) to query the operation result. If the `LatestOperationState` in the response is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyInstancesProjectResponse"/></returns>
        public Task<ModifyInstancesProjectResponse> ModifyInstancesProject(ModifyInstancesProjectRequest req)
        {
            return InternalRequestAsync<ModifyInstancesProjectResponse>(req, "ModifyInstancesProject");
        }

        /// <summary>
        /// This API is used to change the project to which an instance is assigned.
        /// 
        /// * Project is a virtual concept. You can create multiple projects under one account, manage different resources in each project, and assign different instances to different projects. You may use the [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1) API to query instances and use the project ID to filter the results.
        /// * You cannot modify the project of an instance that is bound to a load balancer. You need to unbind the load balancer from the instance by using the [DeregisterInstancesFromLoadBalancer](https://intl.cloud.tencent.com/document/api/214/1258?from_cn_redirect=1) API before using this API.
        /// * Batch operations are supported. Up to 100 instances per request is allowed.
        /// * You can use the API [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) to query the operation result. If the `LatestOperationState` in the response is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyInstancesProjectResponse"/></returns>
        public ModifyInstancesProjectResponse ModifyInstancesProjectSync(ModifyInstancesProjectRequest req)
        {
            return InternalRequestAsync<ModifyInstancesProjectResponse>(req, "ModifyInstancesProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the renewal flag of monthly subscription instances.
        /// 
        /// * After an instance is marked as auto-renewal, it will be automatically renewed for one month each time it expires.
        /// * Batch operations are supported. The maximum number of instances for each request is 100.* You can query the result of the instance operation by calling the API [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5). If the latest operation status (LatestOperationState) of the instance is **SUCCESS**, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstancesRenewFlagResponse"/></returns>
        public Task<ModifyInstancesRenewFlagResponse> ModifyInstancesRenewFlag(ModifyInstancesRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyInstancesRenewFlagResponse>(req, "ModifyInstancesRenewFlag");
        }

        /// <summary>
        /// This API is used to modify the renewal flag of monthly subscription instances.
        /// 
        /// * After an instance is marked as auto-renewal, it will be automatically renewed for one month each time it expires.
        /// * Batch operations are supported. The maximum number of instances for each request is 100.* You can query the result of the instance operation by calling the API [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5). If the latest operation status (LatestOperationState) of the instance is **SUCCESS**, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstancesRenewFlagResponse"/></returns>
        public ModifyInstancesRenewFlagResponse ModifyInstancesRenewFlagSync(ModifyInstancesRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyInstancesRenewFlagResponse>(req, "ModifyInstancesRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the VPC attributes of an instance, such as the VPC IP address.
        /// * This action will shut down the instance, and restart it after the modification is completed.
        /// * To migrate an instance to another VPC/subnet, specify the new VPC and subnet directly. Make sure that the instance to migrate is not bound to an [ENI](https://intl.cloud.tencent.com/document/product/576?from_cn_redirect=1) or [CLB](https://intl.cloud.tencent.com/document/product/214?from_cn_redirect=1) instances.
        /// * You can use the API [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) to query the operation result. If the `LatestOperationState` in the response is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesVpcAttributeResponse"/></returns>
        public Task<ModifyInstancesVpcAttributeResponse> ModifyInstancesVpcAttribute(ModifyInstancesVpcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesVpcAttributeResponse>(req, "ModifyInstancesVpcAttribute");
        }

        /// <summary>
        /// This API is used to modify the VPC attributes of an instance, such as the VPC IP address.
        /// * This action will shut down the instance, and restart it after the modification is completed.
        /// * To migrate an instance to another VPC/subnet, specify the new VPC and subnet directly. Make sure that the instance to migrate is not bound to an [ENI](https://intl.cloud.tencent.com/document/product/576?from_cn_redirect=1) or [CLB](https://intl.cloud.tencent.com/document/product/214?from_cn_redirect=1) instances.
        /// * You can use the API [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) to query the operation result. If the `LatestOperationState` in the response is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesVpcAttributeResponse"/></returns>
        public ModifyInstancesVpcAttributeResponse ModifyInstancesVpcAttributeSync(ModifyInstancesVpcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesVpcAttributeResponse>(req, "ModifyInstancesVpcAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify attributes of a key pair.
        /// 
        /// * Modify the name and description information of the key pair specified by the key pair ID.
        /// * The key pair name should not be the same as the name of an existing key pair.
        /// * The key pair ID is the unique identifier of a key pair and cannot be modified.
        /// 
        /// * Either the key pair name or description information should be specified, and both can also be specified simultaneously.
        /// </summary>
        /// <param name="req"><see cref="ModifyKeyPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyKeyPairAttributeResponse"/></returns>
        public Task<ModifyKeyPairAttributeResponse> ModifyKeyPairAttribute(ModifyKeyPairAttributeRequest req)
        {
            return InternalRequestAsync<ModifyKeyPairAttributeResponse>(req, "ModifyKeyPairAttribute");
        }

        /// <summary>
        /// This API is used to modify attributes of a key pair.
        /// 
        /// * Modify the name and description information of the key pair specified by the key pair ID.
        /// * The key pair name should not be the same as the name of an existing key pair.
        /// * The key pair ID is the unique identifier of a key pair and cannot be modified.
        /// 
        /// * Either the key pair name or description information should be specified, and both can also be specified simultaneously.
        /// </summary>
        /// <param name="req"><see cref="ModifyKeyPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyKeyPairAttributeResponse"/></returns>
        public ModifyKeyPairAttributeResponse ModifyKeyPairAttributeSync(ModifyKeyPairAttributeRequest req)
        {
            return InternalRequestAsync<ModifyKeyPairAttributeResponse>(req, "ModifyKeyPairAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the default version of the instance launch template.
        /// </summary>
        /// <param name="req"><see cref="ModifyLaunchTemplateDefaultVersionRequest"/></param>
        /// <returns><see cref="ModifyLaunchTemplateDefaultVersionResponse"/></returns>
        public Task<ModifyLaunchTemplateDefaultVersionResponse> ModifyLaunchTemplateDefaultVersion(ModifyLaunchTemplateDefaultVersionRequest req)
        {
            return InternalRequestAsync<ModifyLaunchTemplateDefaultVersionResponse>(req, "ModifyLaunchTemplateDefaultVersion");
        }

        /// <summary>
        /// This API is used to modify the default version of the instance launch template.
        /// </summary>
        /// <param name="req"><see cref="ModifyLaunchTemplateDefaultVersionRequest"/></param>
        /// <returns><see cref="ModifyLaunchTemplateDefaultVersionResponse"/></returns>
        public ModifyLaunchTemplateDefaultVersionResponse ModifyLaunchTemplateDefaultVersionSync(ModifyLaunchTemplateDefaultVersionRequest req)
        {
            return InternalRequestAsync<ModifyLaunchTemplateDefaultVersionResponse>(req, "ModifyLaunchTemplateDefaultVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to purchase one or more specific Reserved Instances.
        /// </summary>
        /// <param name="req"><see cref="PurchaseReservedInstancesOfferingRequest"/></param>
        /// <returns><see cref="PurchaseReservedInstancesOfferingResponse"/></returns>
        public Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest req)
        {
            return InternalRequestAsync<PurchaseReservedInstancesOfferingResponse>(req, "PurchaseReservedInstancesOffering");
        }

        /// <summary>
        /// This API is used to purchase one or more specific Reserved Instances.
        /// </summary>
        /// <param name="req"><see cref="PurchaseReservedInstancesOfferingRequest"/></param>
        /// <returns><see cref="PurchaseReservedInstancesOfferingResponse"/></returns>
        public PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOfferingSync(PurchaseReservedInstancesOfferingRequest req)
        {
            return InternalRequestAsync<PurchaseReservedInstancesOfferingResponse>(req, "PurchaseReservedInstancesOffering")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart instances.
        /// 
        /// * You can only perform this operation on instances whose status is `RUNNING`.
        /// * If the API is called successfully, the instance status will become `REBOOTING`. After the instance is restarted, its status will become `RUNNING` again.
        /// * Forced restart is supported. A forced restart is similar to switching off the power of a physical computer and starting it again. It may cause data loss or file system corruption. Be sure to only force start a CVM when it cannot be restarted normally.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public Task<RebootInstancesResponse> RebootInstances(RebootInstancesRequest req)
        {
            return InternalRequestAsync<RebootInstancesResponse>(req, "RebootInstances");
        }

        /// <summary>
        /// This API is used to restart instances.
        /// 
        /// * You can only perform this operation on instances whose status is `RUNNING`.
        /// * If the API is called successfully, the instance status will become `REBOOTING`. After the instance is restarted, its status will become `RUNNING` again.
        /// * Forced restart is supported. A forced restart is similar to switching off the power of a physical computer and starting it again. It may cause data loss or file system corruption. Be sure to only force start a CVM when it cannot be restarted normally.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public RebootInstancesResponse RebootInstancesSync(RebootInstancesRequest req)
        {
            return InternalRequestAsync<RebootInstancesResponse>(req, "RebootInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove the out-of-band network and deployment network of a CHC host.
        /// </summary>
        /// <param name="req"><see cref="RemoveChcAssistVpcRequest"/></param>
        /// <returns><see cref="RemoveChcAssistVpcResponse"/></returns>
        public Task<RemoveChcAssistVpcResponse> RemoveChcAssistVpc(RemoveChcAssistVpcRequest req)
        {
            return InternalRequestAsync<RemoveChcAssistVpcResponse>(req, "RemoveChcAssistVpc");
        }

        /// <summary>
        /// This API is used to remove the out-of-band network and deployment network of a CHC host.
        /// </summary>
        /// <param name="req"><see cref="RemoveChcAssistVpcRequest"/></param>
        /// <returns><see cref="RemoveChcAssistVpcResponse"/></returns>
        public RemoveChcAssistVpcResponse RemoveChcAssistVpcSync(RemoveChcAssistVpcRequest req)
        {
            return InternalRequestAsync<RemoveChcAssistVpcResponse>(req, "RemoveChcAssistVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove the deployment network of a CHC host.
        /// </summary>
        /// <param name="req"><see cref="RemoveChcDeployVpcRequest"/></param>
        /// <returns><see cref="RemoveChcDeployVpcResponse"/></returns>
        public Task<RemoveChcDeployVpcResponse> RemoveChcDeployVpc(RemoveChcDeployVpcRequest req)
        {
            return InternalRequestAsync<RemoveChcDeployVpcResponse>(req, "RemoveChcDeployVpc");
        }

        /// <summary>
        /// This API is used to remove the deployment network of a CHC host.
        /// </summary>
        /// <param name="req"><see cref="RemoveChcDeployVpcRequest"/></param>
        /// <returns><see cref="RemoveChcDeployVpcResponse"/></returns>
        public RemoveChcDeployVpcResponse RemoveChcDeployVpcSync(RemoveChcDeployVpcRequest req)
        {
            return InternalRequestAsync<RemoveChcDeployVpcResponse>(req, "RemoveChcDeployVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ResetInstance) is used to reinstall the operating system on a specified instance.
        /// 
        /// 
        /// 
        /// * If you have specified the parameter `ImageId`, use the specified image for reinstallation. Otherwise, perform reinstallation based on the image currently used by the instance.
        /// * The system disk will be formatted and reset. Ensure that there are no important files in the system disk.
        /// * If you do not specify a password, a random password will be sent via Message Center.
        /// * Currently, only instances with a [system disk type](https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#SystemDisk) of `CLOUD_BASIC`, `CLOUD_PREMIUM`, `CLOUD_SSD`, or `CLOUD_BSSD` are supported for implementing operating system switching through this API.
        /// * You can query the result of the instance operation by calling the API [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5). If the latest operation status (LatestOperationState) of the instance is **SUCCESS**, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ResetInstanceRequest"/></param>
        /// <returns><see cref="ResetInstanceResponse"/></returns>
        public Task<ResetInstanceResponse> ResetInstance(ResetInstanceRequest req)
        {
            return InternalRequestAsync<ResetInstanceResponse>(req, "ResetInstance");
        }

        /// <summary>
        /// This API (ResetInstance) is used to reinstall the operating system on a specified instance.
        /// 
        /// 
        /// 
        /// * If you have specified the parameter `ImageId`, use the specified image for reinstallation. Otherwise, perform reinstallation based on the image currently used by the instance.
        /// * The system disk will be formatted and reset. Ensure that there are no important files in the system disk.
        /// * If you do not specify a password, a random password will be sent via Message Center.
        /// * Currently, only instances with a [system disk type](https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#SystemDisk) of `CLOUD_BASIC`, `CLOUD_PREMIUM`, `CLOUD_SSD`, or `CLOUD_BSSD` are supported for implementing operating system switching through this API.
        /// * You can query the result of the instance operation by calling the API [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5). If the latest operation status (LatestOperationState) of the instance is **SUCCESS**, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ResetInstanceRequest"/></param>
        /// <returns><see cref="ResetInstanceResponse"/></returns>
        public ResetInstanceResponse ResetInstanceSync(ResetInstanceRequest req)
        {
            return InternalRequestAsync<ResetInstanceResponse>(req, "ResetInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the public bandwidth cap of an instance.
        /// 
        /// * The allowed bandwidth cap varies for different models. For details, see [Purchasing Network Bandwidth](https://intl.cloud.tencent.com/document/product/213/509?from_cn_redirect=1).
        /// * For bandwidth billed by the `TRAFFIC_POSTPAID_BY_HOUR` method, changing the bandwidth cap through this API takes effect in real time. Users can increase or reduce bandwidth within applicable limits.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesInternetMaxBandwidthResponse"/></returns>
        public Task<ResetInstancesInternetMaxBandwidthResponse> ResetInstancesInternetMaxBandwidth(ResetInstancesInternetMaxBandwidthRequest req)
        {
            return InternalRequestAsync<ResetInstancesInternetMaxBandwidthResponse>(req, "ResetInstancesInternetMaxBandwidth");
        }

        /// <summary>
        /// This API is used to change the public bandwidth cap of an instance.
        /// 
        /// * The allowed bandwidth cap varies for different models. For details, see [Purchasing Network Bandwidth](https://intl.cloud.tencent.com/document/product/213/509?from_cn_redirect=1).
        /// * For bandwidth billed by the `TRAFFIC_POSTPAID_BY_HOUR` method, changing the bandwidth cap through this API takes effect in real time. Users can increase or reduce bandwidth within applicable limits.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesInternetMaxBandwidthResponse"/></returns>
        public ResetInstancesInternetMaxBandwidthResponse ResetInstancesInternetMaxBandwidthSync(ResetInstancesInternetMaxBandwidthRequest req)
        {
            return InternalRequestAsync<ResetInstancesInternetMaxBandwidthResponse>(req, "ResetInstancesInternetMaxBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the password of the operating system instances to a user-specified password.
        /// 
        /// * To modify the password of the administrator account: the name of the administrator account varies with the operating system. In Windows, it is `Administrator`; in Ubuntu, it is `ubuntu`; in Linux, it is `root`.
        /// * To reset the password of a running instance, you need to set the parameter `ForceStop` to `True` for a forced shutdown. If not, only passwords of stopped instances can be reset.
        /// * Batch operations are supported. You can reset the passwords of up to 100 instances to the same value once.
        /// * You can call the [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) API and find the result of the operation in the response parameter `LatestOperationState`. If the value is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public Task<ResetInstancesPasswordResponse> ResetInstancesPassword(ResetInstancesPasswordRequest req)
        {
            return InternalRequestAsync<ResetInstancesPasswordResponse>(req, "ResetInstancesPassword");
        }

        /// <summary>
        /// This API is used to reset the password of the operating system instances to a user-specified password.
        /// 
        /// * To modify the password of the administrator account: the name of the administrator account varies with the operating system. In Windows, it is `Administrator`; in Ubuntu, it is `ubuntu`; in Linux, it is `root`.
        /// * To reset the password of a running instance, you need to set the parameter `ForceStop` to `True` for a forced shutdown. If not, only passwords of stopped instances can be reset.
        /// * Batch operations are supported. You can reset the passwords of up to 100 instances to the same value once.
        /// * You can call the [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) API and find the result of the operation in the response parameter `LatestOperationState`. If the value is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public ResetInstancesPasswordResponse ResetInstancesPasswordSync(ResetInstancesPasswordRequest req)
        {
            return InternalRequestAsync<ResetInstancesPasswordResponse>(req, "ResetInstancesPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the model of an instance.
        /// * You can only use this API to change the models of instances whose [system disk type](https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`.
        /// * Currently, you cannot use this API to change the models of [CDH](https://intl.cloud.tencent.com/document/product/416?from_cn_redirect=1) instances.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesTypeRequest"/></param>
        /// <returns><see cref="ResetInstancesTypeResponse"/></returns>
        public Task<ResetInstancesTypeResponse> ResetInstancesType(ResetInstancesTypeRequest req)
        {
            return InternalRequestAsync<ResetInstancesTypeResponse>(req, "ResetInstancesType");
        }

        /// <summary>
        /// This API is used to change the model of an instance.
        /// * You can only use this API to change the models of instances whose [system disk type](https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`.
        /// * Currently, you cannot use this API to change the models of [CDH](https://intl.cloud.tencent.com/document/product/416?from_cn_redirect=1) instances.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesTypeRequest"/></param>
        /// <returns><see cref="ResetInstancesTypeResponse"/></returns>
        public ResetInstancesTypeResponse ResetInstancesTypeSync(ResetInstancesTypeRequest req)
        {
            return InternalRequestAsync<ResetInstancesTypeResponse>(req, "ResetInstancesType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ResizeInstanceDisks) is used to expand the data disks of an instance.
        /// 
        /// * Currently, you can only use the API to expand non-elastic data disks whose [disk type](https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`. You can use [`DescribeDisks`](https://intl.cloud.tencent.com/document/api/362/16315?from_cn_redirect=1) to check whether a disk is elastic. If the `Portable` field in the response is `false`, it means that the disk is non-elastic.
        /// * Currently, this API does not support [CDH](https://intl.cloud.tencent.com/document/product/416?from_cn_redirect=1) instances.
        /// * Currently, only one data disk can be expanded at a time.
        /// </summary>
        /// <param name="req"><see cref="ResizeInstanceDisksRequest"/></param>
        /// <returns><see cref="ResizeInstanceDisksResponse"/></returns>
        public Task<ResizeInstanceDisksResponse> ResizeInstanceDisks(ResizeInstanceDisksRequest req)
        {
            return InternalRequestAsync<ResizeInstanceDisksResponse>(req, "ResizeInstanceDisks");
        }

        /// <summary>
        /// This API (ResizeInstanceDisks) is used to expand the data disks of an instance.
        /// 
        /// * Currently, you can only use the API to expand non-elastic data disks whose [disk type](https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`. You can use [`DescribeDisks`](https://intl.cloud.tencent.com/document/api/362/16315?from_cn_redirect=1) to check whether a disk is elastic. If the `Portable` field in the response is `false`, it means that the disk is non-elastic.
        /// * Currently, this API does not support [CDH](https://intl.cloud.tencent.com/document/product/416?from_cn_redirect=1) instances.
        /// * Currently, only one data disk can be expanded at a time.
        /// </summary>
        /// <param name="req"><see cref="ResizeInstanceDisksRequest"/></param>
        /// <returns><see cref="ResizeInstanceDisksResponse"/></returns>
        public ResizeInstanceDisksResponse ResizeInstanceDisksSync(ResizeInstanceDisksRequest req)
        {
            return InternalRequestAsync<ResizeInstanceDisksResponse>(req, "ResizeInstanceDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create one or more instances with a specified configuration.
        /// 
        /// * After an instance is created successfully, it will start up automatically, and the [instance status](https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#instance_state) will become "Running".
        /// * If you create a pay-as-you-go instance billed on an hourly basis, an amount equivalent to the hourly rate will be frozen. Make sure your account balance is sufficient before calling this API.
        /// * The number of instances you can purchase through this API is subject to the [Quota for CVM Instances](https://intl.cloud.tencent.com/document/product/213/2664?from_cn_redirect=1). Instances created through this API and in the CVM console are counted toward the quota.
        /// * This API is an async API. An instance ID list is returned after the creation request is sent. However, it does not mean the creation has been completed. The status of the instance will be `Creating` during the creation. You can use [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1) to query the status of the instance. If the status changes from `Creating` to `Running`, it means that the instance has been created successfully.
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public Task<RunInstancesResponse> RunInstances(RunInstancesRequest req)
        {
            return InternalRequestAsync<RunInstancesResponse>(req, "RunInstances");
        }

        /// <summary>
        /// This API is used to create one or more instances with a specified configuration.
        /// 
        /// * After an instance is created successfully, it will start up automatically, and the [instance status](https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#instance_state) will become "Running".
        /// * If you create a pay-as-you-go instance billed on an hourly basis, an amount equivalent to the hourly rate will be frozen. Make sure your account balance is sufficient before calling this API.
        /// * The number of instances you can purchase through this API is subject to the [Quota for CVM Instances](https://intl.cloud.tencent.com/document/product/213/2664?from_cn_redirect=1). Instances created through this API and in the CVM console are counted toward the quota.
        /// * This API is an async API. An instance ID list is returned after the creation request is sent. However, it does not mean the creation has been completed. The status of the instance will be `Creating` during the creation. You can use [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1) to query the status of the instance. If the status changes from `Creating` to `Running`, it means that the instance has been created successfully.
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public RunInstancesResponse RunInstancesSync(RunInstancesRequest req)
        {
            return InternalRequestAsync<RunInstancesResponse>(req, "RunInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start instances.
        /// 
        /// * You can only perform this operation on instances whose status is `STOPPED`.
        /// * The instance status will become `STARTING` when the API is called successfully and `RUNNING` when the instance is successfully started.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public Task<StartInstancesResponse> StartInstances(StartInstancesRequest req)
        {
            return InternalRequestAsync<StartInstancesResponse>(req, "StartInstances");
        }

        /// <summary>
        /// This API is used to start instances.
        /// 
        /// * You can only perform this operation on instances whose status is `STOPPED`.
        /// * The instance status will become `STARTING` when the API is called successfully and `RUNNING` when the instance is successfully started.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public StartInstancesResponse StartInstancesSync(StartInstancesRequest req)
        {
            return InternalRequestAsync<StartInstancesResponse>(req, "StartInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to shut down instances.
        /// 
        /// * You can only perform this operation on instances whose status is `RUNNING`.
        /// * The instance status will become `STOPPING` when the API is called successfully and `STOPPED` when the instance is successfully shut down.
        /// * Forced shutdown is supported. A forced shutdown is similar to switching off the power of a physical computer. It may cause data loss or file system corruption. Be sure to only force shut down a CVM when it cannot be sht down normally.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public Task<StopInstancesResponse> StopInstances(StopInstancesRequest req)
        {
            return InternalRequestAsync<StopInstancesResponse>(req, "StopInstances");
        }

        /// <summary>
        /// This API is used to shut down instances.
        /// 
        /// * You can only perform this operation on instances whose status is `RUNNING`.
        /// * The instance status will become `STOPPING` when the API is called successfully and `STOPPED` when the instance is successfully shut down.
        /// * Forced shutdown is supported. A forced shutdown is similar to switching off the power of a physical computer. It may cause data loss or file system corruption. Be sure to only force shut down a CVM when it cannot be sht down normally.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public StopInstancesResponse StopInstancesSync(StopInstancesRequest req)
        {
            return InternalRequestAsync<StopInstancesResponse>(req, "StopInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to synchronize custom images to other regions.
        /// 
        /// * This API only supports synchronizing one image per call.
        /// * This API supports multiple synchronization regions.
        /// * A single account can have a maximum of 500 custom images in each region.
        /// </summary>
        /// <param name="req"><see cref="SyncImagesRequest"/></param>
        /// <returns><see cref="SyncImagesResponse"/></returns>
        public Task<SyncImagesResponse> SyncImages(SyncImagesRequest req)
        {
            return InternalRequestAsync<SyncImagesResponse>(req, "SyncImages");
        }

        /// <summary>
        /// This API is used to synchronize custom images to other regions.
        /// 
        /// * This API only supports synchronizing one image per call.
        /// * This API supports multiple synchronization regions.
        /// * A single account can have a maximum of 500 custom images in each region.
        /// </summary>
        /// <param name="req"><see cref="SyncImagesRequest"/></param>
        /// <returns><see cref="SyncImagesResponse"/></returns>
        public SyncImagesResponse SyncImagesSync(SyncImagesRequest req)
        {
            return InternalRequestAsync<SyncImagesResponse>(req, "SyncImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return instances.
        /// 
        /// * Use this API to return instances that are no longer required.
        /// * Pay-as-you-go instances can be returned directly through this API.
        /// * Batch operations are supported. The allowed maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances");
        }

        /// <summary>
        /// This API is used to return instances.
        /// 
        /// * Use this API to return instances that are no longer required.
        /// * Pay-as-you-go instances can be returned directly through this API.
        /// * Batch operations are supported. The allowed maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
